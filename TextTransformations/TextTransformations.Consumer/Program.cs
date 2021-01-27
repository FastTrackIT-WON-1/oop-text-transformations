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

            string result = ApplyTransformationRules(
                text,
                new TransformationRule[] 
                { 
                    new ReplaceTextTransformationRule("test", "test123")
                });

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Transformed text is:");
            Console.WriteLine(result);
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
