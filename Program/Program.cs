using System;
using LSPLibrary;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lanzamos un evento informativo que se notificará
            // solamente por consola
            RaiseInformationEvent("Temperature is 36.8 degrees");

            // Lanzamos un evento severo que se notificará por
            // consola y en el board de Trello
            RaiseSevereEvent("Heart rate is below 60");
        }

        private static void RaiseInformationEvent(string eventName)
        {
            // Usamos el nombre "_event" porque "event" es una keyword.
            Event _event = new Event();
            _event.EventType = "information";
            _event.EventName = eventName;
            _event.Notify();
        }

        private static void RaiseSevereEvent(string eventName)
        {
            // Usamos el nombre "_event" porque "event" es una keyword.
            Event _event = new Event();
            _event.EventType = "severe";
            _event.EventName = eventName;
            _event.Notify();
        }
    }
}
