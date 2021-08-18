using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class R_T_Office : Department, IReception, ITreatment
    {
        public void ReceptionOfPatient(Patient patient, string complain)
        {
            //  Приём больного
            string ticket = "Направление #0000";
            //  Выать напрвление...
        }
        public void TreatmentOfPatients(Patient patient, string diagnos)
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
