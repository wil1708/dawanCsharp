using ExoMVC.DTO;
using ExoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoMVC.Tools
{
    public class Convertisseur
    {
        //Pour le mapping automatique des objets voir AutoMapper dans Nuget

        public static UserDTO UserDtoFromUtilisateur(UserDTO dto, Utilisateur model)
        {

            dto.Id = model.Id;
            dto.Email = model.Email;
            dto.UserName = model.UserName;
            dto.Password = model.Password;
            dto.isAdmin = model.isAdmin;
            dto.Photo = model.Photo;

            return dto;
        }

        public static Utilisateur UtilisateurFromUserDTO(UserDTO dto, Utilisateur model)
        {

            model.Id = dto.Id;
            model.Email = dto.Email;
            model.UserName = dto.UserName;
            model.Password = dto.Password;
            model.isAdmin = dto.isAdmin;
            model.Photo = dto.Photo;

            return model;
        }
    }
}