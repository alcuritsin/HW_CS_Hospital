namespace Hospital
{
    public interface ITreatment
    {
        public void TreatmentOfPatients(Patient patient, string diagnos); // Лечение больных
        public string DetermineDiagnosis(string complain); // Определить диагноз

    }
}
