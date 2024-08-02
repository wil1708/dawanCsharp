using ExoMVC.DTO;
using ExoMVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExoMVC.Services
{
    public class UtilisateurService
    {
        private UtilisateurRepository repo = new UtilisateurRepository();

        public UserDTO findUserByUserNameAndPassword(UserDTO dto)
        {
            UserDTO user = new UserDTO();
            user = repo.findUserByUserNameAndPassword(dto);

            return user;
        }

        public  List<UserDTO> getAllUsers()
        {
            return repo.getAllUsers();
        }

        public UserDTO getUserDTOById(int? id)
        {
            return repo.getUserDTOById(id);
        }

        public void Add(UserDTO userDTO)
        {
            repo.Add(userDTO);
        }

        public void Update(UserDTO userDTO)
        {
            repo.Update(userDTO);
        }

        public void DeleteUserDTO(int id)
        {
            repo.DeleteUserDTO(id);
        }
    }
}