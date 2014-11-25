using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int saldo = 0, saldoregalo = 0, tarjeta, num, opción, contador2 = 0, contador1 = 0, contador3 = 0, contadort = 0, clave, recarga, mensaje, transferir;
            String respuesta="", numero="";
            Console.WriteLine("Introduce tu número");
            numero = Console.ReadLine();
            Console.WriteLine("Introduce tu clave");
            clave = Convert.ToInt32(Console.ReadLine());
            if (numero == "3317439420" && clave == 1234 || numero == "3481137644" && clave == 5678 || numero == "3331431506" && clave == 9876)
            {

                do
                {
                    Console.WriteLine("Marca 1 si quiere realizar una Recarga");
                    Console.WriteLine("Marca 2 si quiere realizar Envío de mensajes");
                    Console.WriteLine("Marca 3 si quiere realizar Transferencia de saldo");
                    opción = Convert.ToInt32(Console.ReadLine());
                    switch (opción)
                    {
                        case 1:
                            contador1 = contador1 + 1;
                            Console.WriteLine("Usted a ingresado a recarga " + contador1 + " veces");
                            Console.WriteLine("Su saldo es: {0:c}", saldo);
                            Console.WriteLine("Su saldo de regalo es:{0:c}", saldoregalo);
                            Console.WriteLine("Marca 1 si quiere recargar $100 con $30 de regalo");
                            Console.WriteLine("Marca 2 si quiere recargar $200 con $40 de regalo");
                            Console.WriteLine("Marca 3 si quiere recargar $500 con $50 de regalo");
                            recarga = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("¿Cuál es tu número de tarjeta? ");
                            tarjeta = Convert.ToInt32(Console.ReadLine());
                            if (tarjeta < 1000000000 && tarjeta > 9999999)
                            {
                                switch (recarga)
                                {
                                    case 1:
                                        saldo = saldo + 100;
                                        saldoregalo = saldoregalo + 30;
                                        Console.WriteLine("Tienes un saldo de: {0:c}", saldo);
                                        Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                        break;
                                    case 2:
                                        saldo = saldo + 200;
                                        saldoregalo = saldoregalo + 40;
                                        Console.WriteLine("Tienes un saldo de: {0:c}", saldo);
                                        Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                        break;
                                    case 3:
                                        saldo = saldo + 500;
                                        saldoregalo = saldoregalo + 50;
                                        Console.WriteLine("Tienes un saldo de {0:c}", saldo);
                                        Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                        break;
                                    default:
                                        Console.WriteLine("Opción inválida");
                                        break;
                                } //switch recarga
                            } //if tarjeta 8 dígitos
                            else
                            {
                                Console.WriteLine("Número de tarjeta inválida");
                            } // else tarjeta
                            break;
                        case 2:
                            contador2 = contador2 + 1;
                            Console.WriteLine("Usted a ingresado a Envío de mensajes" + contador2 + " veces");
                            Console.WriteLine("Su saldo es: {0:c}", saldo);
                            Console.WriteLine("Su saldo de regalo es:{0:c}", saldoregalo);
                            Console.WriteLine("Marca 1 si el mensaje serà a Celulares de la misma empresa");
                            Console.WriteLine("Marca 2 si el mensaje será a Celulares locales");
                            Console.WriteLine("Marca 3 si el mensaje será a Celulares nacionales");
                            Console.WriteLine("Marca 4 si el mensaje será a Celulares internacionales");
                            mensaje = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Introduce el número del teléfono a enviar el mensaje");
                            num = Convert.ToInt32(Console.ReadLine());
                            if (saldoregalo >= 30)
                            {
                                switch (mensaje)
                                {
                                    case 1:
                                        saldoregalo = saldoregalo - 5;
                                        Console.WriteLine("Mensaje enviado a: " + num);
                                        Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                        break;
                                    case 2:
                                        saldoregalo = saldoregalo - 10;
                                        Console.WriteLine("Mensaje enviado a: " + num);
                                        Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                        break;
                                    case 3:
                                        saldoregalo = saldoregalo - 20;
                                        Console.WriteLine("Mensaje enviado a: " + num);
                                        Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                        break;
                                    case 4:
                                        saldoregalo = saldoregalo - 30;
                                        Console.WriteLine("Mensaje enviado a: " + num);
                                        Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                        break;
                                    default:
                                        Console.WriteLine("Opción Inválida");
                                        break;
                                } //switch mensaje
                            } //if saldo regalo
                            else
                            {
                                if (saldoregalo == 20)
                                {
                                    switch (mensaje)
                                    {
                                        case 1:
                                            saldoregalo = saldoregalo - 5;
                                            Console.WriteLine("Mensaje enviado a: " + num);
                                            Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                            break;
                                        case 2:
                                            saldoregalo = saldoregalo - 10;
                                            Console.WriteLine("Mensaje enviado a: " + num);
                                            Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                            break;
                                        case 3:
                                            saldoregalo = saldoregalo - 20;
                                            Console.WriteLine("Mensaje enviado a: " + num);
                                            Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                            break;
                                    }
                                }
                                else
                                {
                                    if (saldoregalo == 10)
                                    {
                                        switch (mensaje)
                                        {
                                            case 1:
                                                saldoregalo = saldoregalo - 5;
                                                Console.WriteLine("Mensaje enviado a: " + num);
                                                Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                                break;
                                            case 2:
                                                saldoregalo = saldoregalo - 10;
                                                Console.WriteLine("Mensaje enviado a: " + num);
                                                Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                                break;
                                        }
                                    }
                                    else
                                    {
                                        if (saldoregalo == 5)
                                        {
                                            saldoregalo = saldoregalo - 5;
                                            Console.WriteLine("Mensaje enviado a: " + num);
                                            Console.WriteLine("Tu saldo de regalo es: {0:c}", saldoregalo);
                                        }
                                        else
                                        {
                                            Console.WriteLine("No cuentas con saldo suficiente se te descontara de tu saldo regular");
                                            switch (mensaje)
                                            {
                                                case 1:
                                                    saldo = saldo - 5;
                                                    Console.WriteLine("Mensaje enviado a: " + num);
                                                    Console.WriteLine("Tu saldo de regalo es: {0:c}", saldo);
                                                    break;
                                                case 2:
                                                    saldo = saldo - 10;
                                                    Console.WriteLine("Mensaje enviado a: " + num);
                                                    Console.WriteLine("Tu saldo de regalo es: {0:c}", saldo);
                                                    break;
                                                case 3:
                                                    saldo = saldo - 20;
                                                    Console.WriteLine("Mensaje enviado a: " + num);
                                                    Console.WriteLine("Tu saldo de regalo es: {0:c}", saldo);
                                                    break;
                                                case 4:
                                                    saldo = saldo - 30;
                                                    Console.WriteLine("Mensaje enviado a: " + num);
                                                    Console.WriteLine("Tu saldo de regalo es: {0:c}", saldo);
                                                    break;
                                                default:
                                                    Console.WriteLine("Opción Inválida");
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }

                            break;
                        case 3:
                            Console.WriteLine("Su saldo es: {0:c}", saldo);
                            Console.WriteLine("Su saldo de regalo es:{0:c}", saldoregalo);
                            contador3 = contador3 + 1;
                            Console.WriteLine("Usted a ingresado a Transferencia de saldo" + contador3 + " veces");
                            do
                            {
                                Console.WriteLine("Marca 1 si quiere transferir $50");
                                Console.WriteLine("Marca 2 si quire transferir $100");
                                transferir = Convert.ToInt32(Console.ReadLine());
                                if (saldo <= 50)
                                {
                                    saldo = saldo - 50;
                                    contadort = contadort + 1;
                                    Console.WriteLine("Tu saldo es: {0:c}", saldo);
                                }
                                else
                                {
                                    if (saldo >= 100)
                                    {
                                        saldo = saldo - 100;
                                        contadort = contadort + 1;
                                        Console.WriteLine("Tu saldo es: {0:c}", saldo);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No cuenta con saldo suficiente");
                                    }
                                }
                            } while (contadort <= 3);
                            break;

                            
                    }
                    Console.WriteLine("Deseas volver al menú de inicio? Si o no");
                    respuesta = Convert.ToString(Console.ReadLine());
                } while (respuesta == "si" || respuesta == "Si");
            }
            else
            {
                Console.WriteLine("Número y clave inválidos");
            }
            Console.ReadLine();
        }
    }
}




