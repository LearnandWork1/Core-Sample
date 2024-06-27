using CoreSample.Model.ViewModel;

namespace CoreSample.Model.Interface
{
    public interface IPatientDetails
    {
        Task<List<PatientDetailsMaster>> GetAllPatientDetails();

        Task<int> AddPatientDetails(PatientDetailsMaster patientDetailsMaster);

        int UpdateAllPatientDetails(PatientDetailsMaster patientDetailsMaster);
        int DeletePatientDetails(int ID);

        PatientDetailsMaster UpdatePatientDetailsByID(PatientDetailsMaster patientDetailsMasters);
        int DeletePatientDetailsByID(int ID);

    }
}
