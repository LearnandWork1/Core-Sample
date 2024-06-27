using CoreSample.Model.Interface;
using CoreSample.Model.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace CoreSample.Model.Service
{
    public class PatientDetailsService : IPatientDetails
    {

        //public PatientDetailsService() { }

        private readonly patientDBContext _context;

        public PatientDetailsService(patientDBContext context)
        {
            _context = context;
        }


        public async Task<List<PatientDetailsMaster>> GetAllPatientDetails()
        {
           
                var PatientDetailsList = await _context.patientDetailsMasters.ToListAsync();
                return PatientDetailsList;
           
        }


        public async Task<int> AddPatientDetails(PatientDetailsMaster patientDetailsMasters)
        {
            try
            {
                _context.patientDetailsMasters.Add(patientDetailsMasters);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public PatientDetailsMaster UpdatePatientDetailsByID(PatientDetailsMaster patientDetailsMasters)
        {
            try
            {
                var record = _context.patientDetailsMasters.Single(R => R.PatientID == patientDetailsMasters.PatientID);
                record.FirstName = patientDetailsMasters.FirstName;
                record.LastName = patientDetailsMasters.LastName;
                record.Age = patientDetailsMasters.Age;
                record.Address = patientDetailsMasters.Address;
                record.AdmittedLocation = record.AdmittedLocation;

                _context.SaveChanges();

                return record;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public int DeletePatientDetailsByID(int ID)
        {
            try
            {
                var patientDetailsMaster = _context.patientDetailsMasters.Single(d => d.PatientID == ID);
                _context.patientDetailsMasters.Remove(patientDetailsMaster);
                //_context.rentMasters.ExecuteDelete();
                int res = _context.SaveChanges(true);

                return res;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public int UpdateAllPatientDetails(PatientDetailsMaster patientDetailsMaster)
        {
            //context.Entry(rentmaster).State = EntityState.Modified;
            //return _context.SaveChanges();

            return 0;
        }
        
        public int DeletePatientDetails(int ID)
        {
            try
            {
                //_context.patientDetailsMasters.ExecuteDelete();
                //return await _context.SaveChangesAsync();
                return 0;

            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
