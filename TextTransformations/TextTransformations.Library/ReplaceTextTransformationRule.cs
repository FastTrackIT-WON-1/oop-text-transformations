namespace TextTransformations.Library
{
    public class ReplaceTextTransformationRule : TransformationRule
    {
        public ReplaceTextTransformationRule(
            string oldText,
            string newText)
        {
            OldText = oldText;
            NewText = newText;
        }

        public string OldText { get; }

        public string NewText { get; }

        public override string Process(string input)
        {
            return input.Replace(OldText, NewText);
        }
    }
}
