<?php

interface TareaObservable
{

    function addObserver(TareaObserver $observer);

    function removeObserver(TareaObserver $observer);

    function notificar(Tarea $tarea);
}