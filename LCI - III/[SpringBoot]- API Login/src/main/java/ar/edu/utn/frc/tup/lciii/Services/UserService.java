package ar.edu.utn.frc.tup.lciii.Services;

import ar.edu.utn.frc.tup.lciii.Models.UserModel;
import org.springframework.stereotype.Service;

@Service
public interface UserService {

    UserModel getUser();

    UserModel postUser(UserModel user);

}
