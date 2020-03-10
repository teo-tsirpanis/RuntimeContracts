﻿#define CONTRACTS_LIGHT_PRECONDITIONS
using System;
using System.Diagnostics.FluentContracts;
using Xunit;

namespace RuntimeContracts.FluentContracts.Test
{
    public class ContractPreconditionTests
    {
        [Fact]
        public void CorrectExceptionTypeShouldBeGenerated()
        {
            Assert.Throws<ArgumentNullException>(() => WillFail(null));

            static void WillFail(string s)
            {
                //Contract.Requires<ArgumentNullException>(s != null, "custom message");
            }
        }

        [Fact]
        public void PreconditionsShouldFail()
        {
            someMethod(-1);

            void someMethod(int arg)
            {

                Contract.Requires(arg > 0)?.IsTrue("message");

                //ContractFluentExtensions.IsTrue(Contract.Requires(false), "message");
            }
        }
    }
}
