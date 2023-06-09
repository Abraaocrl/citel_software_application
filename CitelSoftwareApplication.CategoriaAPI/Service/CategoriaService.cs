﻿using CitelSoftwareApplication.CategoriaAPI.Data;
using CitelSoftwareApplication.CategoriaAPI.Model.Domain;
using CitelSoftwareApplication.CategoriaAPI.Repository.Interface;
using CitelSoftwareApplication.CategoriaAPI.Service.Interface;
using Mapster;

namespace CitelSoftwareApplication.CategoriaAPI.Service
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _repository;

        public CategoriaService(ICategoriaRepository repository)
        {
            _repository = repository;
        }

        public async Task<CategoriaDTO> Create(CategoriaDTO categoriaDto)
        {
            return (await _repository.CreateAsync(categoriaDto.Adapt<Categoria>())).Adapt<CategoriaDTO>();
        }

        public async Task<bool> DeleteByIdAsync(long id)
        {
            var categoria = await _repository.GetByIdAsync(id);
            if (categoria == null) return false;

            return await _repository.DeleteAsync(categoria);
        }

        public async Task<IEnumerable<CategoriaDTO>> GetAllAsync()
        {
            return (await _repository.GetAllAsync()).Adapt<IEnumerable<CategoriaDTO>>();
        }

        public async Task<CategoriaDTO> GetByIdAsync(long id)
        {
            var categoriaDb = await _repository.GetByIdAsync(id);
            if (categoriaDb == null)
            {
                throw new NotFoundException("Categoria não encontrada");
            }

            return categoriaDb.Adapt<CategoriaDTO>();
        }

        public async Task<CategoriaDTO> Update(CategoriaDTO categoriaDto)
        {
            var categoriaDb = await _repository.GetByIdAsync(categoriaDto.Id);
            if(categoriaDb == null)
            {
                throw new NotFoundException("Categoria não encontrada");
            }

            return (await _repository.UpdateAsync(categoriaDto.Adapt<Categoria>())).Adapt<CategoriaDTO>();
        }

        public async Task<int> GetContagemAsync()
        {
            return await _repository.GetCountAsync();
        }
    }
}
