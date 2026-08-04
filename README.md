# PF_Preguntados — Juego de Trivia Educativo

![VB.NET](https://img.shields.io/badge/VB.NET-.NET%20Framework%204.7.2-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/UI-WinForms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Database](https://img.shields.io/badge/Database-MS%20Access%20%7C%20SQL%20Server-00599C?style=for-the-badge&logo=microsoftaccess&logoColor=white)
![Reporting](https://img.shields.io/badge/Reports-MS%20Office%20Interop%20%28Word%2FPDF%2FExcel%29-217346?style=for-the-badge&logo=microsoftoffice&logoColor=white)
![License](https://img.shields.io/badge/License-Academic-blue?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Completed-success?style=for-the-badge)

---

## Descripción del Proyecto

**PF_Preguntados** es una aplicación de escritorio interactiva tipo trivia/quiz educativo desarrollada en **VB.NET (WinForms)** sobre **.NET Framework 4.7.2**. El sistema fue diseñado con un enfoque pedagógico dinámico para permitir a los profesores evaluar a sus estudiantes mediante juegos temáticos interactivos, mientras automatiza la recolección de estadísticas, puntajes y la generación exhaustiva de reportes académicos en formato Word, PDF y Excel.

---

## Autores y Créditos Académicos

* **Proyecto:** Proyecto Final de Programación IV (Agosto, 2024)
* **Institución:** Universidad Hispanoamericana — Bachillerato en Ingeniería Informática (San José, Costa Rica)
* **Profesor:** Dr. Marcos Andrés Salas Jiménez, PhD.
* **Desarrolladores:**
  * Minor Porras Varela
  * Christian Peña Méndez
  * Luis Pérez Sánchez[cite: 3, 4]
  * Joseph Campos Matarrita[cite: 3, 4]

---

## Documentación y Manuales del Proyecto

Toda la documentación oficial del sistema se encuentra organizada en la carpeta [`/draft1proyectoPrograIV/Manuales`](./draft1proyectoPrograIV/Manuales/). Puedes consultar o descargar los manuales directamente desde los siguientes enlaces:

| Documento | Descripción | Formato | Enlace Directo |
| :--- | :--- | :---: | :---: |
| 👤 **Manual de Usuario** | Guía de uso de la interfaz para estudiantes y profesores. | `PDF` | 📄 [Ver Manual de Usuario](./draft1proyectoPrograIV/Manuales/Manual%20de%20usuario.pdf) |
| 🛠️ **Manual Técnico** | Arquitectura del sistema, instalación de dependencias y despliegue. | `PDF` | 📄 [Ver Manual Técnico](./draft1proyectoPrograIV/Manuales/Manual%20T%C3%A9cnico.pdf) |
| 🗄️ **Diccionario de Base de Datos** | Estructura detallada de tablas, campos, llaves y relaciones. | `DOCX` | 📥 [Descargar Diccionario](./draft1proyectoPrograIV/Manuales/Diccionario%20Base%20de%20datos%20Proyecto%20Final%20(1).docx) |
| 🔑 **Instrucciones de Administrador** | Configuración inicial y credenciales del usuario Superusuario (`SU`). | `TXT` | 📝 [Ver Instrucciones](./draft1proyectoPrograIV/Manuales/Intrucciones%20de%20Adminidtrador.txt) |


## Características Principales

### 1. Motor de Juego (Trivia Interactiva)
* **Gestión de Estado (`PROCESO_JUEGO`):** Control dinámico en tiempo de ejecución de temas, categorías, preguntas, respuestas y puntajes.
* **Mecanismo de Ruleta:** Selección de categorías mediante pantallas de ruleta animadas (`P_EJuegoCategoria`).
* **Temporizador y Feedback en Vivo:** Cada pregunta cuenta con tiempo límite por temporizador (`TimerPreg`), validación visual de respuesta (correcta/incorrecta), asignación inmediata de puntos y retroalimentación/explicación pedagógica.
* **Cálculo y Guardado Automatizado:** Al finalizar las categorías, la pantalla de resultados (`P_EJuegoResultados`) procesa la nota global y guarda el intento en la base de datos.

### 2. Control de Acceso Basado en Roles (RBAC)
* **Administrador (`SU`):**
  * Gestión global de cuentas de profesores[cite: 4].
  * Credenciales por defecto iniciales: `Usuario: SU` | `Clave: 17964`[cite: 2].
* **Profesor / Docente:**
  * Mantenimiento de información estudiantil (Secciones, Niveles, Períodos, Asignaturas y Estudiantes)[cite: 4].
  * Personalización completa del juego (Creación de Temas, Categorías, Preguntas y Respuestas)[cite: 4].
  * Soporte multimedia para preguntas/categorías (Imágenes estáticas, GIFs animados, Audio `.wav` y Video)[cite: 1, 4].
  * Generación y exportación de reportes académicos[cite: 4].
* **Estudiante:**
  * Acceso modular a pruebas/juegos asignados por tema[cite: 4].
  * Consulta individual de notas, puntos obtenidos, tiempo total e historial de respuestas[cite: 4].

### 3. Motor de Reportes e Informes (MS Office Interop)
* **Reporte General:**
  * Métricas avanzadas por sección y tema[cite: 4].
  * Identificación automática de la pregunta más fácil, pregunta más difícil, estudiante con mayor calificación y mayor cantidad de aciertos[cite: 4].
* **Reporte Individual:**
  * Desglose detallado de puntos obtenidos vs. totales, nota final, tiempo empleado y fecha de realización[cite: 4].
  * **Modos de Envío/Exportación:** Completo, solo respuestas incorrectas, solo respuestas correctas, o sin envío (formatos Word/Excel/PDF)[cite: 4].

---

##<img width="500" height="500" alt="Logo" src="https://github.com/user-attachments/assets/6cea53fd-e494-49ad-bcdb-e44ceb22e29d" />

## 🛠️ Requisitos del Sistema e Instalación

### 💻 Requisitos de Hardware
* **Procesador:** Intel Core i3 / AMD Ryzen 5 5500 o superior.
* **Memoria RAM:** 4 GB mínimo.
* **Almacenamiento:** 10 MB de espacio disponible.

### 💾 Requisitos de Software
* **Sistema Operativo:** Windows 10 / Windows 11.
* **Dependencias y Drivers:**
  * Suite Microsoft Office / Microsoft 365 (Microsoft Access y Word/Excel para reportes).
  * Microsoft Access Database Engine 2016 Redistributable (Driver OLEDB/ODBC).

### 🚀 Pasos de Instalación
1. **Instalar Motor de Base de Datos:**
   * Descargar `AccessDatabaseEngine.exe`.
   * Ejecutar la instalación desatendida mediante la consola de comandos (`cmd`):
     ```cmd
     cd C:\Ruta\De\Descarga
     AccessDatabaseEngine.exe /quiet
     ```
2. **Ejecutar el Instalador de la Aplicación:**
   * Descomprimir el archivo del proyecto (`Preguntado.rar`).
   * Ejecutar `setup.exe` o `draft1proyectoPrograIV.application`.
   * Si Windows SmartScreen muestra una advertencia, seleccionar **"Más información"** → **"Ejecutar de todos modos"**.

---

## ⌨️ Atajos de Teclado y Controles

| Tecla | Acción |
| :---: | :--- |
| <kbd>ESC</kbd> | Cierra la ventana actual o sale de la aplicación. |
| <kbd>ENTER</kbd> | Acciona la opción principal o el botón verde resaltado. |
| <kbd>1</kbd> – <kbd>5</kbd> | Selección rápida de opciones numéricas en los menús principales. |

---

## 🔧 Preguntas Frecuentes y Solución de Problemas

* **¿Formato de audio permitido para las preguntas?**
  * La aplicación soporta exclusivamente archivos en formato `.wav`.
* **¿Por qué un estudiante no puede cambiar su foto de perfil?**
  * Por diseño de permisos, solo los docentes pueden actualizar la foto de perfil e información personal del estudiante.
* **Error de conexión a la base de datos al iniciar:**
  * Verifique que el controlador *Access Database Engine 2016* esté instalado correctamente ejecutando la sintaxis `/quiet`.












