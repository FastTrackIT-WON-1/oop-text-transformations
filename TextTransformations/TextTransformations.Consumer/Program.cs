using System;
using TextTransformations.Library;

namespace TextTransformations.Consumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter text=");
            string text = Console.ReadLine();

            string result1 = ApplyTransformationRules(
                text,
                new TransformationRule[] 
                {
                    new InsertStringTransformationRule(0, "Petre "),
                    new DeleteTextTransformationRule("test"),
                    new ReplaceTextTransformationRule("a", "test123")
                });


            string result2 = ApplyTransformationRules(
                text,
                new TransformationRule[]
                {
                    new InsertStringTransformationRule(0, "Rodica "),
                    new ReplaceTextTransformationRule("test", "test123")
                });


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Transformed text 1 is:");
            Console.WriteLine(result1);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Transformed text 2 is:");
            Console.WriteLine(result2);
        }

        static string ApplyTransformationRules(
            string input,
            TransformationRule[] transformationRules)
        {
            if (transformationRules is null)
            {
                return input;
            }

            foreach (TransformationRule rule in transformationRules)
            {
                input = rule.Process(input);
            }

            return input;
        }
    }
}
