package ar.edu.utn.frc.tup.lciii.DTOs;

import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
public class PartidaDTO {

    //TODO ES RESPONSABILIDAD DEL SERVIDOR MANEJAR EL ID DE LA PARTIDA NO DEL CLIENTE.
    private String jugadorUno;
    private String jugadorDos;
    private String elemento;



}
