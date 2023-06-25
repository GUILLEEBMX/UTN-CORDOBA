package ar.edu.utn.frc.tup.lciii.entities;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Table(name = "partida")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class PartidaEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @Column
    private String jugadorUno;

    @Column
    private String jugadorDos;

    @Column
    private String elemento;

}
