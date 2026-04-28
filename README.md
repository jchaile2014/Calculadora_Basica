# Calculadora de Consola en C#

Aplicación de consola desarrollada en C# .NET que permite realizar operaciones matemáticas básicas y guarda un historial de todas las operaciones en un archivo de texto.

---

## Funcionalidades

- **Suma**
- **Resta**
- **Multiplicación**
- **División** (con control de división por cero)
- **Módulo / Resto** (con control de división por cero)
- **Historial de operaciones** guardado automáticamente en `historial_operaciones.txt` con fecha y hora de cada operación
- **Validación de entrada** — rechaza texto y acepta tanto coma como punto como separador decimal

---

## Tecnologías utilizadas

| Tecnología | Detalle |
|---|---|
| Lenguaje | C# |
| Framework | .NET 10 |
| IDE | Visual Studio |
| Tipo de proyecto | Aplicación de consola |
| Persistencia | Archivo de texto plano (`.txt`) |

---

## Estructura del proyecto

```
Calculadora/
├── Calculadora.sln        # Solución de Visual Studio
├── Calculadora/
│   ├── Calculadora.csproj # Proyecto
│   └── Program.cs         # Código fuente principal
└── historial_operaciones.txt  # Se genera al ejecutar
```

---

## Cómo ejecutar

### Desde Visual Studio
1. Abrir `Calculadora.slnx`
2. Presionar `F5` o el botón **Ejecutar**

### Desde la terminal
```bash
cd Calculadora
dotnet run
```

---

## Ejemplo de uso

```
╔══════════════════════════════╗
║       CALCULADORA C#         ║
╠══════════════════════════════╣
║  1. Suma                     ║
║  2. Resta                    ║
║  3. Multiplicacion           ║
║  4. Division                 ║
║  5. Modulo (resto)           ║
║  6. Ver historial            ║
║  0. Salir                    ║
╚══════════════════════════════╝
Seleccione una opcion: 1
Ingrese el primer numero: 15
Ingrese el segundo numero: 7
Resultado: 15 + 7 = 22
Operacion guardada en 'historial_operaciones.txt'
```

El archivo `historial_operaciones.txt` registra cada operación con su timestamp:

```
[2026-04-28 14:35:10]  15 + 7 = 22
[2026-04-28 14:36:05]  100 / 4 = 25
[2026-04-28 14:36:40]  9 % 4 = 1
```

---

## Autor
**Jorge Ariel Chaile**
📧 jchaile2014@gmail.com
💼 [LinkedIn](https://linkedin.com/in/jorge-ariel-chaile-072294261)
💻 [GitHub](https://github.com/jchaile2014)
