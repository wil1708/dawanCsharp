using MVC.DTO;
using MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Services
{
    public class UtilisateurService
    {
        UtilisateurRepository repo = new UtilisateurRepository();

        public UserDTO findByUserNameAndPassword(UserDTO dto)
        {
            UserDTO user = new UserDTO();
            user = repo.findByUserNameAndPassword(dto);
            return user;
        }
    }
}