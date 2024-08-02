using MVC.DTO;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Tools
{
    public class Convetisseur
    {
        public static UserDTO DtoFromUtilisateur(Utilisateur user, UserDTO dto)
        {
            dto.UserName = user.UserName;
            dto.Password = user.Password;
            dto.Id = user.Id;
            dto.isAdmin = user.isAdmin;
            dto.Email = user.Email;
            return dto;
        }
    }
}