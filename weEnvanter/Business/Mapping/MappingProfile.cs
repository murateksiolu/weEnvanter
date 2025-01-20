using AutoMapper;
using weEnvanter.Business.DTOs;
using weEnvanter.Domain.Entities;

namespace weEnvanter.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Department mappings
            CreateMap<Department, DepartmentDto>();
            CreateMap<DepartmentCreateDto, Department>();
            CreateMap<DepartmentUpdateDto, Department>();

            // Employee mappings
            CreateMap<Employee, EmployeeDto>()
                .ForMember(dest => dest.DepartmentName,
                          opt => opt.MapFrom(src => src.Department.Name));
            CreateMap<EmployeeCreateDto, Employee>();
            CreateMap<EmployeeUpdateDto, Employee>();

            // Inventory mappings
            CreateMap<Inventory, InventoryDto>()
                .ForMember(dest => dest.CategoryName,
                          opt => opt.MapFrom(src => src.InventoryCategory.Name));
            CreateMap<InventoryCreateDto, Inventory>();
            CreateMap<InventoryUpdateDto, Inventory>();

            // InventoryAssignment mappings
            CreateMap<InventoryAssignment, InventoryAssignmentDto>()
                .ForMember(dest => dest.InventoryName,
                          opt => opt.MapFrom(src => src.Inventory.Name))
                .ForMember(dest => dest.EmployeeName,
                          opt => opt.MapFrom(src => $"{src.Employee.FirstName} {src.Employee.LastName}"));
            CreateMap<InventoryAssignmentCreateDto, InventoryAssignment>();
            CreateMap<InventoryAssignmentUpdateDto, InventoryAssignment>();

            // InventoryCategory mappings
            CreateMap<InventoryCategory, InventoryCategoryDto>();
            CreateMap<InventoryCategoryCreateDto, InventoryCategory>();
            CreateMap<InventoryCategoryUpdateDto, InventoryCategory>();

            // MaintenanceRecord mappings
            CreateMap<MaintenanceRecord, MaintenanceRecordDto>()
                .ForMember(dest => dest.InventoryName,
                          opt => opt.MapFrom(src => src.Inventory.Name));
            CreateMap<MaintenanceRecordCreateDto, MaintenanceRecord>();
            CreateMap<MaintenanceRecordUpdateDto, MaintenanceRecord>();
        }
    }
} 