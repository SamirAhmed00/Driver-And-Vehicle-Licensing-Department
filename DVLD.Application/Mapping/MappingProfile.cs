using AutoMapper;
using DVLD.Application.DTOs;
using DVLD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DVLD.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Person Mapping
            CreateMap<Person, PersonDTO>().ReverseMap();

            // User Mapping
            CreateMap<User, UserDTO>().ReverseMap();

            // Application Mapping
            CreateMap<DVLD.Domain.Entities.Application, ApplicationDTO>().ReverseMap();
            CreateMap<ApplicationType, ApplicationTypeDTO>().ReverseMap();

            // License Mapping
            CreateMap<License, LicenseDTO>().ReverseMap();
            CreateMap<LicenseClass, LicenseClassDTO>().ReverseMap();
            CreateMap<InternationalLicense, InternationalLicenseDTO>().ReverseMap();

            // Driver Mapping
            CreateMap<Driver, DriverDTO>().ReverseMap();

            // Test & Appointment Mapping
            CreateMap<TestType, TestTypeDTO>().ReverseMap();
            CreateMap<TestAppointment, TestAppointmentDTO>().ReverseMap();
            CreateMap<Test, TestDTO>().ReverseMap();

            // Others
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<DetainedLicense, DetainedLicenseDTO>().ReverseMap();
            CreateMap<LocalDrivingLicenseApplication, LocalDrivingLicenseApplicationDTO>().ReverseMap();
        }
    }
}
