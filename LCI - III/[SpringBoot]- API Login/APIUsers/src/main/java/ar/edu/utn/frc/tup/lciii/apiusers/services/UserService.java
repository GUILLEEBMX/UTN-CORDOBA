package ar.edu.utn.frc.tup.lciii.apiusers.services;

import ar.edu.utn.frc.tup.lciii.apiusers.models.UserModel;
import org.springframework.stereotype.Service;

@Service
public interface UserService {

    UserModel getUser();


}
