namespace ExercicioFixacao.Entities
{
    public class Instalment
    {
        public double DueValue { get; set; }
        public DateTime DueDate { get; set; }

        public Instalment(double dueValue, DateTime dueDate)
        {
            DueValue = dueValue;
            DueDate = dueDate;
        }
    }
}