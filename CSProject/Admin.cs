namespace CSProject
{
    public class Admin : Staff
    {
        private const float overtimeRate =  15.5f;
        private const float adminHourlyRate = 30f;
        
        public float Overtime { get; private set; }
        public override float CalculatePay()
        {
            return base.CalculatePay();
        }
    }
}