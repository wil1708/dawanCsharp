using MVC.DTO;
using MVC.Models;
using MVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Repositories
{
    public class UtilisateurRepository
    {

        public UserDTO findByUserNameAndPassword(UserDTO dto)
        {
            UserDTO userDTO = new UserDTO();
            using (MyContext context = new MyContext())
            {
                Utilisateur ut = context.Utilisateurs.FirstOrDefault(u => u.UserName.Equals(dto.UserName) && u.Password.Equals(dto.Password));
                if (ut != null)
                {
                    Convetisseur.DtoFromUtilisateur(ut, userDTO);
                }
                
            }
            return userDTO;
        }
    }
}