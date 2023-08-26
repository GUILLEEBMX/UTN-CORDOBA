package ar.edu.utn.frc.tup.lciii.apiusers.models;

import ar.edu.utn.frc.tup.lciii.apiusers.services.UserService;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
public class UserModel {

    private String name;
    private String password;

    public UserModel(String name, String password){
        this.name = name;
        this.password = password;
    }

    public UserModel(){

    }

}
