package ar.edu.utn.frc.tup.lciii.apiusers.services.implementation;

import ar.edu.utn.frc.tup.lciii.apiusers.models.UserModel;
import ar.edu.utn.frc.tup.lciii.apiusers.services.UserService;

public class UserServiceImplementation implements UserService {
    @Override
    public UserModel getUser() {
        return new UserModel("GUILLERMO","ROLLING13.");
    }
}
