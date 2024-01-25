using QA_project.actions;

namespace QA_project.MenuLogic
{
    internal class OptionsMenu
    {
        public static List<Options> Optionss = new List<Options>()
        {
            new Options()
            {
                Title = "Add",
                OpenOperation = Addition.ShowAddResults
            },
            new Options()
            {
                Title = "Extract",
                OpenOperation = Extraction.ShowExtractResults
            },
            new Options()
            {
                Title = "Multiply",
                OpenOperation = Multiplying.ShowMultiplyResults
            },
            new Options()
            {
                Title = "Division",
                OpenOperation = Division.ShowDivisionResults
            },
            new Options()
            {
                Title = "Exit",
                OpenOperation = Greetings.Stop
            },
            
        };
    }
}
