package ar.edu.utn.frc.tup.lciii.Services.Implementation;

import ar.edu.utn.frc.tup.lciii.Models.UserModel;
import ar.edu.utn.frc.tup.lciii.Services.UserService;
import org.apache.catalina.User;
import org.springframework.stereotype.Service;

@Service
public class UserServiceImplementation implements UserService {
    @Override
    public UserModel getUser() {
        return new UserModel("GUILLERMO", "ROLLING13.");
    }

    @Override
    public UserModel postUser(UserModel user) {
        return new UserModel("LEONARDO", "ESTO ES UN POST");
    }
}
