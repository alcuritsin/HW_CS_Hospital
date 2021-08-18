namespace Hospital
{
    public class ReceptionOffice : Department, IReception
    {
        //  Только приём больных
        public Doctor Doctor { get; set; }  //  Доктор
        public void ReceptionOfPatient(Patient patient, string complain)
        {
            //  Приём больного
            string ticket = "Направление #0000";
            //  Выать талон...
        }
    }
}
