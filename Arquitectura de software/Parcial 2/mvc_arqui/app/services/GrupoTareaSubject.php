<?php

class GrupoTareaSubject implements TareaObservable
{
    private array $observers;
    private CursoMateria $cursoMateria;

    public function __construct(CursoMateria $cursoMateria)
    {
        $this->cursoMateria = $cursoMateria;
        $this->observers = array();
    }

    public function getCursoMateria(): CursoMateria
    {
        return $this->cursoMateria;
    }

    function addObserver(TareaObserver $observer)
    {
        array_push($this->observers, $observer);
    }

    function removeObserver(TareaObserver $observer)
    {
        $this->observers = array_diff($this->observers, array($observer));
    }

    function notificar(Tarea $tarea)
    {
        foreach ($this->observers as $observer) {
            $observer->notificar($tarea);
        }
    }
}