namespace Hospital
{
    public class TreatmentOffice : Department, ITreatment
    {
        public Doctor Doctor { get; set; }  //  Доктор

        public void TreatmentOfPatients(Patient patient, string complain)
        {
            // Лечим больного.
        }
        public string DetermineDiagnosis(string complain)
        {
            //  Определить диагноз
            switch (complain)
            {
                case "Жалоба 1":
                    return "Диагноз 1";
                default:
                    return "Новая болезнь.";
            }
        }

    }
}
