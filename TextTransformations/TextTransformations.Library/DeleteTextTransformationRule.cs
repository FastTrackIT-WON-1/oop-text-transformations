namespace TextTransformations.Library
{
    public class DeleteTextTransformationRule : TransformationRule
    {
        public DeleteTextTransformationRule(string textToDelete)
        {
            TextToDelete = textToDelete;
        }

        public string TextToDelete { get; }

        public override string Process(string input)
        {
            return input.Replace(TextToDelete, string.Empty);
        }
    }
}
