﻿using BibliotecaBusiness.Abstractions;
using BibliotecaBusiness.Models;

namespace BibliotecaBusiness.Services
{
    public class CriarContaService
    {
        private readonly IRifadorRepository rifadorRepository;

        public CriarContaService(IRifadorRepository rifadorRepository)
        {
            this.rifadorRepository = rifadorRepository;
        }

        public ServiceResult CriarContaRifador(Rifador rifador)
        {
            ServiceResult serviceResult = new ServiceResult();

            try 
            {
                rifadorRepository.AdicionarRifador(rifador);
                serviceResult.Success = true;
            }
            catch (Exception e) 
            {
                serviceResult.Success= false;
                serviceResult.Erros.Add(e.Message);               
            }
            
            return serviceResult;
        }
    }
}
