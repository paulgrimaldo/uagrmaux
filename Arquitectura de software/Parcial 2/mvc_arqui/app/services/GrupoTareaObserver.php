<?php

class GrupoTareaObserver implements TareaObserver
{
    public Grupo $grupo;

    public function __construct(Grupo $grupo)
    {
        $this->grupo = $grupo;
    }


    function notificar(Tarea $tarea)
    {
        $emails = $this->grupo->getAlumnosEmails();
        $toMails = "";
        foreach ($emails as $email) {
            $toMails = $toMails . $email[0] . ', ';
        }

        $notificacion = 'Se notificó a ' . $toMails . ' sobre la tarea: ' . $tarea->nombre;
        $_SESSION['notificacion'] = $notificacion;
    }
}