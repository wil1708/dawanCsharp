using ExoMVC.DTO;
using ExoMVC.Models;
using ExoMVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoMVC.Repositories
{
    public class UtilisateurRepository
    {
        public UserDTO findUserByUserNameAndPassword(UserDTO dto)
        {
            UserDTO user = new UserDTO();
            using (MyContext context = new MyContext())
            {
                Utilisateur model = context.Utilisateurs.FirstOrDefault(x => x.UserName.Equals(dto.UserName) && x.Password.Equals(dto.Password));
                if (model != null && model.Id != 0)
                {
                    user = Convertisseur.UserDtoFromUtilisateur(dto, model);
                }
            }

            return user;
        }

        public UserDTO getUserDTOById(int? id)
        {
            UserDTO dto = new UserDTO();
            using (MyContext context = new MyContext())
            {
                Utilisateur model = context.Utilisateurs.Find(id);
                if (model != null)
                {
                    dto = Convertisseur.UserDtoFromUtilisateur(dto, model);
                }
            }
            return dto;
        }

        public void DeleteUserDTO(int id)
        {
            using (MyContext context = new MyContext())
            {
                Utilisateur u =context.Utilisateurs.Find(id);
                context.Utilisateurs.Remove(u);
                context.SaveChanges();
            }
        }

        public void Update(UserDTO userDTO)
        {
            using (MyContext context = new MyContext())
            {
                Utilisateur u = context.Utilisateurs.Find(userDTO.Id); //changed
                u = Convertisseur.UtilisateurFromUserDTO(userDTO, u); //Modified - Added - Deleted - Attached - Detached
                context.SaveChanges(); //SQL Update
            }    
        }

        public void Add(UserDTO userDTO)
        {
            Utilisateur u = Convertisseur.UtilisateurFromUserDTO(userDTO, new Utilisateur());
            using (MyContext context = new MyContext())
            {
                context.Utilisateurs.Add(u);
                context.SaveChanges();
            }
        }

        public List<UserDTO> getAllUsers()
        {
            List<UserDTO> lst = new List<UserDTO>();
            //UserDTO dto = new UserDTO(); 
            using (MyContext context = new MyContext())
            {
                List<Utilisateur> lstModel = context.Utilisateurs.ToList();
                foreach (Utilisateur model in lstModel)
                {
                    lst.Add(Convertisseur.UserDtoFromUtilisateur(new UserDTO(), model));
                }
            }

            return lst;
        }
    }
}