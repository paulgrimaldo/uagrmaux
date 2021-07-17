package com.grimaldo.ed2.familytree;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Ronaldo Rivero
 */
public class Nodo implements Serializable{
    
    private String varon;
    private String mujer;
    private List<Nodo> hijos;
    
    public Nodo(String varon) {
        this.varon = varon;
        this.mujer = null;
        this.hijos = new ArrayList<Nodo>();
    }

    public String getVaron() {
        return varon;
    }

    public void setVaron(String varon) {
        this.varon = varon;
    }

    public String getMujer() {
        return mujer;
    }

    public void setMujer(String mujer) {
        this.mujer = mujer;
    }
        
    public void agregarHijo(Nodo p) {
        hijos.add(p);
    }
    
    public int cantidadHijos() {
        return hijos.size();
    }
    
    public Nodo getHijo(int i) {
        if(i >= 1 && i <= hijos.size()) {
            return hijos.get(i-1);
        } else {
            System.err.println("No existe el hijo Nº"+i);
            return null;
        }
    }
    
    public boolean esHoja() {
        return hijos.size() == 0;
    }
    
    public String visualizar() {
        //[Ronaldo/Carla]
        //[Paul]
        String s = "[" + varon;
        if(mujer!=null){
            s+= "/" + mujer;
        }
        s+= "]";
        return s;
    }
}
