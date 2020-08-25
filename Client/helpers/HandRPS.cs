namespace firstBlazorApp.Client.Helpers
{
    public class HandRPS
    {
        public OptionRPS SelectedOption { get; set; }
        public OptionRPS WinsAgainst { get; set; }
        public OptionRPS LosesAgainst { get; set; }
        public string Image { get; set; }
        public string AltText { get; set; }

        public GameStatus PlayAgainst(HandRPS opponentHand)
        {
            if (SelectedOption == opponentHand.SelectedOption)
            {
                return GameStatus.Draw;
            }
            if (LosesAgainst == opponentHand.SelectedOption)
            {
                return GameStatus.Loss;
            }
            return GameStatus.Victory;
        }
    }
}