namespace BlazorTalentCalc.Shared.Models
{
    public class TalentPosition
    {
        public int Row { get; private set; }
        public int Column { get; private set; }

        public TalentPosition(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
