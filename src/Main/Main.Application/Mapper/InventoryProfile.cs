﻿using AutoMapper;
using Main.Application.Dtos;
using Main.Application.Dtos.Inventories.Create;
using Main.Application.Dtos.Inventories.Index;
using Main.Domain.Entities.Inventories;

namespace Main.Application.Mapper
{
    public class InventoryProfile : Profile
    {
        public InventoryProfile()
        {
            CreateMap<CreateInventoryDto, Inventory>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Trim()))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description != null ? src.Description.Trim() : null))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.CurrentSequence, opt => opt.MapFrom(_ => 1))
                .ForMember(dest => dest.Fields, opt => opt.Ignore())
                .ForMember(dest => dest.Tags, opt => opt.Ignore()) 
                .ForMember(dest => dest.OwnerId, opt => opt.Ignore())
                .ForMember(dest => dest.AccessList, opt => opt.Ignore());

            CreateMap<CreateInventoryFieldDto, InventoryField>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Trim()))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description != null ? src.Description.Trim() : null))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow));

            CreateMap<Inventory, InventoryDto>()
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(t => t.Tag.Name).ToList()))
                .ForMember(dest => dest.Fields, opt => opt.MapFrom(src => src.Fields));

            CreateMap<InventoryDto, Inventory>()
                .ForMember(dest => dest.Fields, opt => opt.MapFrom((src, dest, destMember, context) =>
                {
                    if (src.Fields == null) return new List<InventoryField>();

                    return src.Fields.Select(fieldDto =>
                    {
                        var field = context.Mapper.Map<InventoryField>(fieldDto);
                        field.InventoryId = src.Id;
                        return field;
                    }).ToList();
                }))
                .ForMember(dest => dest.Tags, opt => opt.Ignore()) 
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.OwnerId, opt => opt.Ignore())
                .ForMember(dest => dest.Items, opt => opt.Ignore())
                .ForMember(dest => dest.Comments, opt => opt.Ignore())
                .ForMember(dest => dest.AccessList, opt => opt.Ignore());

            CreateMap<InventoryFieldDto, InventoryField>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name.Trim()))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description != null ? src.Description.Trim() : null))
                .ForMember(dest => dest.FieldType, opt => opt.MapFrom(src => src.FieldType))
                .ForMember(dest => dest.OrderIndex, opt => opt.MapFrom(src => src.OrderIndex))
                .ForMember(dest => dest.IsVisibleInTable, opt => opt.MapFrom(src => src.IsVisibleInTable))
                .ForMember(dest => dest.IsRequired, opt => opt.MapFrom(src => src.IsRequired))
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.InventoryId, opt => opt.Ignore()) 
                .ForMember(dest => dest.Inventory, opt => opt.Ignore());

            CreateMap<Inventory, InventoryFormDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                .ForMember(dest => dest.IsPublic, opt => opt.MapFrom(src => src.IsPublic))
                .ForMember(dest => dest.CustomIdFormat, opt => opt.MapFrom(src => src.CustomIdFormat))
                .ForMember(dest => dest.Version, opt => opt.MapFrom(src => Convert.ToBase64String(src.Version)))
                .ForMember(dest => dest.Tags, opt => opt.MapFrom(src => src.Tags.Select(t => t.Tag.Name).ToList()))
                .ForMember(dest => dest.Fields, opt => opt.MapFrom(src => src.Fields))
                .ForMember(dest => dest.AccessList, opt => opt.MapFrom(src => src.AccessList));

            CreateMap<InventoryAccess, InventoryAccessDto>()
                .ForMember(dest => dest.InventoryId, opt => opt.MapFrom(src => src.InventoryId))
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.GrantedById, opt => opt.MapFrom(src => src.GrantedById))
                .ForMember(dest => dest.GrantedAt, opt => opt.MapFrom(src => src.GrantedAt))
                .ForMember(dest => dest.AccessLevel, opt => opt.MapFrom(src => src.AccessLevel))
                .ForMember(dest => dest.Inventory, opt => opt.MapFrom(src => src.Inventory));

            CreateMap<InventoryFormDto, Inventory>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id ?? 0))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
                .ForMember(dest => dest.IsPublic, opt => opt.MapFrom(src => src.IsPublic))
                .ForMember(dest => dest.CustomIdFormat, opt => opt.MapFrom(src => src.CustomIdFormat))
                .ForMember(dest => dest.Version, opt => opt.MapFrom(src =>
                    src.Version != null ? Convert.FromBase64String(src.Version) : new byte[8]))
                .ForMember(dest => dest.Tags, opt => opt.Ignore()) 
                .ForMember(dest => dest.Fields, opt => opt.Ignore())
                .ForMember(dest => dest.AccessList, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.OwnerId, opt => opt.Ignore())
                .ForMember(dest => dest.Items, opt => opt.Ignore())
                .ForMember(dest => dest.Comments, opt => opt.Ignore());

            CreateMap<CreateInventoryFieldDto, InventoryFieldDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.FieldType, opt => opt.MapFrom(src => src.FieldType))
                .ForMember(dest => dest.OrderIndex, opt => opt.MapFrom(src => src.OrderIndex))
                .ForMember(dest => dest.IsVisibleInTable, opt => opt.MapFrom(src => src.IsVisibleInTable))
                .ForMember(dest => dest.IsRequired, opt => opt.MapFrom(src => src.IsRequired));

            CreateMap<InventoryField, CreateInventoryFieldDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
                .ForMember(dest => dest.FieldType, opt => opt.MapFrom(src => src.FieldType))
                .ForMember(dest => dest.OrderIndex, opt => opt.MapFrom(src => src.OrderIndex))
                .ForMember(dest => dest.IsVisibleInTable, opt => opt.MapFrom(src => src.IsVisibleInTable))
                .ForMember(dest => dest.IsRequired, opt => opt.MapFrom(src => src.IsRequired));

            CreateMap<InventoryField, InventoryFieldDto>().ReverseMap();
            CreateMap<InventoryAccess, InventoryAccessDto>().ReverseMap();
        }
    }
}