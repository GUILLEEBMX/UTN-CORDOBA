package ar.edu.utn.frc.tup.lciii.Models;


import lombok.Getter;
import lombok.Setter;

public class Partida {


    //TODO REFACTORIZAR UNA PARTIDA DEBERIA TENER UNA CLASE JUGADORES.
    //TODO LA RELACION SERIA UNA PARTIDA 2 JUGADORES.
    //TODO CONFIGURAR RELACION EN LAS ENTITIES NUEVAMENTE.
    @Getter
    @Setter
    Long id;
    @Getter
    @Setter
    String jugadorUno;
    @Getter
    @Setter
    String jugadorDos;
    @Getter
    @Setter
    String elemento;




    //cantidad inicio
    //cantidad restante
    //ganador


}
