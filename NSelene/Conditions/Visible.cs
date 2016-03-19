﻿namespace NSelene
{
    namespace Conditions
    {
        public class Visible : DescribedCondition<SElement>
        {

            public override bool Apply(SElement entity)
            {
                return entity().Displayed;
            }

            public override string DescribeActual()
            {
                return false.ToString();
            }

            public override string DescribeExpected()
            {
                return true.ToString();
            }
        }

    }

    public static partial class Be
    {
        public static Conditions.Condition<SElement> Visible = new Conditions.Visible();
    }

}