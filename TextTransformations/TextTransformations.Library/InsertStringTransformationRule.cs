using System;
using System.Collections.Generic;
using System.Text;

namespace TextTransformations.Library
{
    public class InsertStringTransformationRule : TransformationRule
    {
        public InsertStringTransformationRule(
            int index,
            string text)
        {
            Index = index;
            Text = text;
        }

        public int Index { get; }

        public string Text { get; }

        public override string Process(string input)
        {
            return input.Insert(Index, Text);
        }
    }
}
