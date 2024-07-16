﻿using BibliotecaBusiness.Abstractions;
using BibliotecaBusiness.Models;

namespace BibliotecaBusiness.Services
{
    public class ExcluirBilheteServices
    {
        private readonly IBilheteRepository bilheteRepository;

        public ExcluirBilheteServices(IBilheteRepository bilheteRepository)
        {
            this.bilheteRepository = bilheteRepository;
        }

        public ServiceResult ExcluirBilhete(Bilhete bilhete)
        {
            ServiceResult serviceResult = new ServiceResult();

            try
            {
                bilheteRepository.ExcluirBilhete(bilhete);
                serviceResult.Success = true;   
            }
            catch(Exception e)
            {
                serviceResult.Success = false;
                serviceResult.Erros.Add(e.Message);
            }

            return serviceResult;
        }
    }
}
