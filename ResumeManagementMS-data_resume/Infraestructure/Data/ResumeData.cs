﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Infraestructure.Data
{
    public class ResumeData
    {
        public static void SeedData(EntityTypeBuilder<Resume> builder)
        {
            builder.HasData(
                new Resume
                {
                    UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85"),
                    Description = "Leonel Esquivel es un desarrollador full-stack con más de 10 años de experiencia en el desarrollo de aplicaciones utilizando C# y .NET. Es reconocido por su capacidad para diseñar y mantener sistemas robustos y escalables, y tiene un historial comprobado de trabajo exitoso en proyectos de gran envergadura. Leonel es un profesional proactivo con habilidades excepcionales en la resolución de problemas y un enfoque meticuloso en la calidad del código.",
                    MinimumSalary = 60000,
                    Image = "https://example.com/image_leonel.jpg"
                },

                new Resume
                {
                    UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473"),
                    Description = "Ana Gomez es una desarrolladora front-end experta en React y Angular, con una sólida trayectoria en la creación de interfaces de usuario atractivas y funcionales. Con más de 8 años de experiencia en el campo, Ana ha trabajado en diversos proyectos innovadores, siempre enfocándose en la usabilidad y la experiencia del usuario. Su habilidad para traducir los requisitos del cliente en soluciones técnicas efectivas es destacable.",
                    MinimumSalary = 55000,
                    Image = "https://example.com/image_ana.jpg"
                },

new Resume
{
    UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8"),
    Description = "Carlos Rodriguez es un desarrollador backend especializado en Java y el framework Spring, con más de 12 años de experiencia en la industria. Carlos se destaca por su capacidad para diseñar y optimizar sistemas backend complejos, asegurando la eficiencia y escalabilidad. Su experiencia abarca desde la creación de APIs robustas hasta la gestión de bases de datos, siempre con un enfoque en la solución de problemas y la mejora continua.",
    MinimumSalary = 65000,
    Image = "https://example.com/image_carlos.jpg"
},
new Resume
{
    UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84"),
    Description = "Maria Garcia es una profesional apasionada por el desarrollo web, con experiencia en HTML, CSS y JavaScript. Su enfoque meticuloso en el diseño y la usabilidad le ha permitido crear interfaces atractivas y funcionales. María se destaca por su habilidad para trabajar en equipo y su capacidad para adaptarse rápidamente a nuevas tecnologías. Con un historial probado de entrega de proyectos de calidad en plazos ajustados, María es una adición valiosa a cualquier equipo de desarrollo.",
    MinimumSalary = 45000,
    Image = "https://example.com/image_maria.jpg"
},
new Resume
{
    UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931"),
    Description = "Jose Luis es un desarrollador full-stack con experiencia en diversas tecnologías, incluyendo Java, Python y JavaScript. Con más de 8 años de experiencia en el campo, José ha liderado equipos de desarrollo y ha entregado proyectos exitosos en plazos ajustados. Su pasión por la resolución de problemas y su enfoque en la calidad del código lo distinguen como un profesional altamente competente. José está constantemente buscando oportunidades para crecer y aprender, y está comprometido con la excelencia en todo lo que hace.",
    MinimumSalary = 60000,
    Image = "https://example.com/image_jose.jpg"
},
new Resume
{
    UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb"),
    Description = "Luis Fernandez es un diseñador UX/UI con experiencia en la creación de interfaces intuitivas y atractivas. Su enfoque centrado en el usuario y su atención al detalle se reflejan en sus diseños, que han sido elogiados por su funcionalidad y estética. Luis es un colaborador comprometido y proactivo, siempre buscando oportunidades para mejorar la experiencia del usuario. Con una sólida comprensión de los principios de diseño y una habilidad para comunicarse eficazmente, Luis es capaz de transformar las ideas en experiencias digitales impactantes.",
    MinimumSalary = 50000,
    Image = "https://example.com/image_luis.jpg"
},
new Resume
{
    UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad"),
    Description = "Marta Rivera es una desarrolladora front-end con experiencia en React, Vue.js y Angular. Con un enfoque en la creación de interfaces de usuario dinámicas y responsivas, Marta ha contribuido al éxito de varios proyectos web. Su habilidad para colaborar efectivamente con diseñadores y desarrolladores la convierte en un miembro valioso de cualquier equipo. Marta está comprometida con la mejora continua y está constantemente explorando nuevas tecnologías y técnicas para mantenerse al día con las últimas tendencias en desarrollo web.",
    MinimumSalary = 55000,
    Image = "https://example.com/image_marta.jpg"
},
new Resume
{
    UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9"),
    Description = "Miguel Sanchez es un ingeniero de software con experiencia en el desarrollo de aplicaciones móviles nativas para iOS y Android. Su profundo conocimiento de Swift, Kotlin y las mejores prácticas de diseño de aplicaciones lo ha llevado a entregar productos de alta calidad que cumplen con las expectativas del cliente. Miguel es un solucionador de problemas habilidoso con una pasión por la innovación tecnológica. Con una mentalidad orientada al detalle y una capacidad para gestionar proyectos complejos, Miguel está preparado para enfrentar cualquier desafío de desarrollo móvil con éxito.",
    MinimumSalary = 65000,
    Image = "https://example.com/image_miguel.jpg"
},
new Resume
{
    UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978"),
    Description = "¡Hola! Soy Laura Hernandez, una entusiasta del diseño gráfico con una pasión por la creatividad y la innovación. Con más de 5 años de experiencia en el campo, he trabajado en una variedad de proyectos, desde diseño de logotipos hasta campañas publicitarias completas. Mi enfoque se centra en crear diseños visualmente impactantes que no solo sean estéticamente agradables, sino también funcionales y efectivos para transmitir el mensaje deseado. Siempre estoy buscando desafíos emocionantes que me permitan expandir mis habilidades y aprender nuevas técnicas. ¡Estoy emocionada de colaborar en tu próximo proyecto y llevar tus ideas a la vida! ¡Contáctame y comencemos a crear algo increíble juntos!",
    MinimumSalary = 55000,
    Image = "https://example.com/image_laura.jpg"
},
new Resume
{
    UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f"),
    Description = "¡Hola! Soy David Martin, un apasionado desarrollador de software con una sólida experiencia en el desarrollo de aplicaciones web y móviles. Mi fascinación por la tecnología y mi habilidad para resolver problemas me han llevado a construir aplicaciones robustas y escalables que satisfacen las necesidades de mis clientes. Con habilidades en múltiples lenguajes de programación y frameworks, estoy preparado para enfrentar cualquier desafío de desarrollo que se presente. Siempre estoy buscando oportunidades para aprender y crecer profesionalmente, y estoy emocionado de contribuir con mi experiencia a tu próximo proyecto. ¡Hablemos y veamos cómo puedo ayudarte a alcanzar tus objetivos tecnológicos!",
    MinimumSalary = 65000,
    Image = "https://example.com/image_david.jpg"
},
new Resume
{
    UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675"),
    Description = "¡Hola! Soy Sara Perez, una apasionada del marketing digital con experiencia en estrategias de contenido, redes sociales y SEO. A lo largo de mi carrera, he trabajado en diversas campañas que han generado resultados significativos para mis clientes. Mi enfoque se centra en comprender las necesidades del cliente y crear estrategias personalizadas que impulsen el compromiso y la conversión. Con un ojo para el detalle y una mentalidad analítica, estoy constantemente buscando formas de optimizar y mejorar el rendimiento de las campañas. ¡Estoy emocionada de colaborar contigo y ayudarte a alcanzar tus objetivos de marketing digital!",
    MinimumSalary = 60000,
    Image = "https://example.com/image_sara.jpg"
},
new Resume
{
    UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8"),
    Description = "¡Hola! Soy Juan Carlos, un desarrollador de aplicaciones móviles con experiencia en el diseño y desarrollo de aplicaciones nativas para iOS y Android. Mi pasión por la tecnología y mi habilidad para traducir ideas creativas en productos funcionales me han permitido crear aplicaciones que impactan positivamente en la vida de los usuarios. Con un enfoque en la usabilidad y el rendimiento, me esfuerzo por ofrecer experiencias móviles de alta calidad que superen las expectativas del cliente. Estoy emocionado de trabajar en tu próximo proyecto y contribuir con mi experiencia para hacerlo un éxito. ¡Hablemos y hagamos realidad tu visión!",
    MinimumSalary = 70000,
    Image = "https://example.com/image_juan.jpg"
},
new Resume
{
    UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36"),
    Description = "¡Hola! Soy Carmen Lopez, una diseñadora de moda con una pasión por la creación de prendas únicas y elegantes. Con un ojo para las tendencias y una habilidad para combinar colores y telas de manera creativa, he creado colecciones que han cautivado a clientes de todo el mundo. Mi enfoque se centra en la calidad, la originalidad y la atención al detalle, y estoy comprometida a ofrecer productos que no solo sean hermosos, sino también cómodos y funcionales. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y contribuir al mundo de la moda. ¡Contáctame y hagamos magia juntos!",
    MinimumSalary = 75000,
    Image = "https://example.com/image_carmen.jpg"
},
new Resume
{
    UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754"),
    Description = "¡Hola! Soy Pablo Martinez, un diseñador gráfico con una pasión por la creatividad y el arte visual. Con más de 7 años de experiencia en el campo, he trabajado en una variedad de proyectos que abarcan desde diseño de logotipos y branding hasta ilustraciones y diseño editorial. Mi enfoque se centra en capturar la esencia de cada proyecto y transmitirlo a través de diseños únicos y atractivos. Estoy constantemente buscando nuevas inspiraciones y tendencias para mejorar mi trabajo y ofrecer resultados excepcionales a mis clientes. ¡Estoy emocionado de colaborar en tu próximo proyecto y ayudarte a alcanzar tus objetivos de diseño!",
    MinimumSalary = 60000,
    Image = "https://example.com/image_pablo.jpg"
},
new Resume
{
    UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f"),
    Description = "¡Hola! Soy Gloria Ramos, una profesional del marketing digital con experiencia en estrategias de contenido, redes sociales y publicidad online. A lo largo de mi carrera, he tenido el privilegio de trabajar con una variedad de clientes y marcas para ayudarles a alcanzar sus objetivos de marketing. Mi enfoque se centra en entender las necesidades y preferencias de la audiencia para crear campañas efectivas que generen resultados tangibles. Estoy comprometida con la excelencia en cada proyecto y estoy emocionada de poder contribuir con mi experiencia a tu equipo. ¡Juntos podemos crear estrategias que impulsen tu negocio hacia el éxito!",
    MinimumSalary = 65000,
    Image = "https://example.com/image_gloria.jpg"
},
new Resume
{
    UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6"),
    Description = "¡Hola! Soy Antonio Alvarez, un desarrollador web con experiencia en la creación de sitios web y aplicaciones web dinámicas y funcionales. Con más de 5 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde pequeñas empresas hasta grandes corporaciones. Mi enfoque se centra en entender las necesidades del cliente y ofrecer soluciones personalizadas que superen sus expectativas. Estoy emocionado de trabajar en proyectos desafiantes que me permitan aplicar y mejorar mis habilidades. ¡Estoy listo para contribuir con mi experiencia y hacer una diferencia en tu equipo de desarrollo!",
    MinimumSalary = 70000,
    Image = "https://example.com/image_antonio.jpg"
},
new Resume
{
    UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26"),
    Description = "¡Hola! Soy Patricia Flores, una diseñadora de moda con una pasión por la creación de prendas únicas y elegantes. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos que abarcan desde diseño de alta costura hasta ropa casual y deportiva. Mi enfoque se centra en la calidad, la originalidad y la innovación, y estoy comprometida a ofrecer productos que no solo sean hermosos, sino también cómodos y funcionales. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y contribuir al mundo de la moda. ¡Contáctame y hagamos magia juntos!",
    MinimumSalary = 75000,
    Image = "https://example.com/image_patricia.jpg"
},
new Resume
{
    UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090"),
    Description = "¡Hola! Soy Andres Romero, un desarrollador de software con experiencia en el diseño y desarrollo de aplicaciones móviles y web. Con más de 6 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde aplicaciones móviles para startups hasta soluciones empresariales complejas. Mi enfoque se centra en entender las necesidades del usuario y ofrecer soluciones intuitivas y efectivas que mejoren su experiencia. Estoy emocionado de trabajar en proyectos desafiantes que me permitan aplicar y mejorar mis habilidades como desarrollador. ¡Estoy listo para enfrentar cualquier desafío y hacer una contribución significativa a tu equipo!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_andres.jpg"
},
new Resume
{
    UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729"),
    Description = "¡Hola! Soy Elena Diaz, una profesional del marketing digital con una pasión por la creación de estrategias innovadoras y efectivas. Con más de 5 años de experiencia en el campo, he trabajado en una variedad de proyectos que abarcan desde redes sociales hasta campañas de email marketing. Mi enfoque se centra en comprender las necesidades del cliente y crear soluciones personalizadas que impulsen el compromiso y la conversión. Estoy comprometida con la excelencia en cada proyecto y estoy emocionada de poder contribuir con mi experiencia a tu equipo. ¡Juntos podemos crear estrategias que impulsen tu negocio hacia el éxito!",
    MinimumSalary = 60000,
    Image = "https://example.com/image_elena.jpg"
},
new Resume
{
    UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414"),
    Description = "¡Hola! Soy Roberto Hidalgo, un desarrollador full-stack con experiencia en la creación de aplicaciones web y móviles. Con más de 8 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde startups hasta grandes empresas. Mi enfoque se centra en entender las necesidades del usuario y ofrecer soluciones eficientes y escalables que mejoren su experiencia. Estoy emocionado de trabajar en proyectos desafiantes que me permitan aplicar y mejorar mis habilidades como desarrollador. ¡Estoy listo para enfrentar cualquier desafío y hacer una contribución significativa a tu equipo!",
    MinimumSalary = 65000,
    Image = "https://example.com/image_roberto.jpg"
},
new Resume
{
    UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439"),
    Description = "¡Hola! Soy Pedro Gomez, un ingeniero de software con experiencia en el desarrollo de aplicaciones empresariales y sistemas informáticos. Con más de 7 años de experiencia en el campo, he trabajado en una variedad de proyectos que abarcan desde aplicaciones de gestión hasta sistemas de análisis de datos. Mi enfoque se centra en la calidad del código, la eficiencia y la escalabilidad de las soluciones que desarrollo. Estoy emocionado de contribuir con mi experiencia a tu equipo y ayudarte a alcanzar tus objetivos tecnológicos. ¡Juntos podemos construir soluciones innovadoras que impulsen tu negocio hacia el éxito!",
    MinimumSalary = 70000,
    Image = "https://example.com/image_pedro.jpg"
},
new Resume
{
    UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82"),
    Description = "¡Hola! Soy Isabel Hernandez, una diseñadora de moda con una pasión por la creación de prendas elegantes y atemporales. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos que abarcan desde moda casual hasta alta costura. Mi enfoque se centra en la calidad, la originalidad y la atención al detalle, y estoy comprometida a ofrecer productos que no solo sean hermosos, sino también cómodos y funcionales. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y contribuir al mundo de la moda. ¡Contáctame y hagamos magia juntos!",
    MinimumSalary = 75000,
    Image = "https://example.com/image_isabel.jpg"
},
new Resume
{
    UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7"),
    Description = "¡Hola! Soy Rafael Martinez, un consultor de negocios con experiencia en estrategia empresarial y gestión de proyectos. Con más de 6 años de experiencia en el campo, he trabajado con una variedad de empresas para identificar oportunidades de crecimiento y mejorar la eficiencia operativa. Mi enfoque se centra en comprender las necesidades específicas de cada cliente y desarrollar soluciones prácticas y personalizadas que generen resultados tangibles. Estoy emocionado de colaborar en proyectos desafiantes que me permitan aplicar y expandir mis habilidades como consultor. ¡Estoy listo para enfrentar cualquier desafío y ayudarte a llevar tu negocio al siguiente nivel!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_rafael.jpg"
},
new Resume
{
    UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1"),
    Description = "¡Hola! Soy Ana Maria, una diseñadora de interiores apasionada por crear espacios acogedores y funcionales que reflejen la personalidad y el estilo de mis clientes. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos residenciales y comerciales, desde pequeñas renovaciones hasta remodelaciones completas. Mi enfoque se centra en entender las necesidades y gustos de mis clientes para crear diseños únicos y personalizados que superen sus expectativas. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y mejorar la calidad de vida de las personas a través del diseño de interiores. ¡Contáctame y hagamos realidad tu visión!",
    MinimumSalary = 70000,
    Image = "https://example.com/image_ana.jpg"
},
new Resume
{
    UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb"),
    Description = "¡Hola! Soy Juan Antonio, un desarrollador de software con experiencia en el diseño y desarrollo de aplicaciones web y móviles. Con más de 6 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde startups hasta grandes empresas. Mi enfoque se centra en la calidad del código, la eficiencia y la escalabilidad de las soluciones que desarrollo. Estoy emocionado de contribuir con mi experiencia a tu equipo y ayudarte a alcanzar tus objetivos tecnológicos. ¡Juntos podemos construir soluciones innovadoras que impulsen tu negocio hacia el éxito!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_juan.jpg"
},
new Resume
{
    UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1"),
    Description = "¡Hola! Soy Sofia Gonzalez, una contadora pública con experiencia en la gestión financiera y contable de empresas. Con más de 7 años de experiencia en el campo, he trabajado en una variedad de industrias, desde la manufactura hasta la tecnología. Mi enfoque se centra en proporcionar información financiera precisa y oportuna que permita a las empresas tomar decisiones informadas y estratégicas. Estoy comprometida con la excelencia en cada proyecto y estoy emocionada de poder contribuir con mi experiencia a tu equipo. ¡Juntos podemos lograr el éxito financiero de tu empresa!",
    MinimumSalary = 90000,
    Image = "https://example.com/image_sofia.jpg"
},
new Resume
{
    UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f"),
    Description = "¡Hola! Soy Alejandro, un ingeniero civil con experiencia en el diseño y construcción de infraestructuras civiles. Con más de 8 años de experiencia en el campo, he trabajado en una variedad de proyectos que van desde edificios residenciales hasta carreteras y puentes. Mi enfoque se centra en la calidad del diseño, la seguridad y la eficiencia de las estructuras que construyo. Estoy emocionado de contribuir con mi experiencia a tu equipo y ayudarte a llevar a cabo proyectos que mejoren la calidad de vida de las personas. ¡Juntos podemos construir un futuro mejor!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_alejandro.jpg"
},
new Resume
{
    UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f"),
    Description = "¡Hola! Soy Lucia Ramos, una fotógrafa apasionada por capturar momentos especiales y crear recuerdos duraderos a través de la fotografía. Con más de 5 años de experiencia en la industria, he tenido el privilegio de trabajar en una variedad de eventos, desde bodas y sesiones familiares hasta eventos corporativos y comerciales. Mi enfoque se centra en capturar la esencia y la emoción de cada momento de una manera auténtica y artística. Estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y contar historias a través de mis imágenes. ¡Contáctame y creemos recuerdos juntos!",
    MinimumSalary = 75000,
    Image = "https://example.com/image_lucia.jpg"
},
new Resume
{
    UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f"),
    Description = "¡Hola! Soy Diego López, un chef apasionado por la gastronomía y la creación de experiencias culinarias memorables. Con más de 10 años de experiencia en la industria, he tenido el privilegio de trabajar en una variedad de restaurantes, desde pequeños bistros hasta establecimientos de alta cocina. Mi enfoque se centra en la calidad de los ingredientes, la creatividad en la presentación y la atención al detalle en cada plato que preparo. Estoy emocionado de colaborar en proyectos que me permitan compartir mi pasión por la cocina y sorprender a los comensales con sabores únicos y deliciosos. ¡Contáctame y organicemos una experiencia gastronómica inolvidable!",
    MinimumSalary = 70000,
    Image = "https://example.com/image_diego.jpg"
},
new Resume
{
    UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206"),
    Description = "¡Hola! Soy Paula Pérez, una abogada especializada en derecho laboral con experiencia en la defensa de los derechos de los trabajadores. Con más de 8 años de experiencia en el campo, he representado a clientes en una variedad de casos, desde despidos injustificados hasta reclamaciones de salarios y beneficios. Mi enfoque se centra en proporcionar asesoramiento legal integral y estratégico que proteja los intereses de mis clientes y garantice un trato justo en el lugar de trabajo. Estoy comprometida con la justicia y la equidad y estoy emocionada de poder ayudarte a resolver tus problemas legales laborales. ¡Contáctame y defendamos tus derechos juntos!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_paula.jpg"
},
new Resume
{
    UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7"),
    Description = "¡Hola! Soy Roberto Morales, un arquitecto apasionado por el diseño innovador y sostenible. Con más de 10 años de experiencia en la industria, he liderado proyectos que van desde edificios residenciales hasta complejos comerciales y urbanizaciones. Mi enfoque se centra en la integración de la arquitectura con el entorno natural y la creación de espacios que promuevan el bienestar y la sostenibilidad. Estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y creatividad para crear lugares inspiradores y funcionales. ¡Contáctame y hagamos realidad tus ideas arquitectónicas!",
    MinimumSalary = 90000,
    Image = "https://example.com/image_roberto.jpg"
},
new Resume
{
    UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9"),
    Description = "¡Hola! Soy Teresa Díaz, una terapeuta ocupacional comprometida con el bienestar y la calidad de vida de mis pacientes. Con más de 8 años de experiencia en el campo, he trabajado con personas de todas las edades y condiciones para ayudarles a recuperar habilidades motoras y funcionales y mejorar su independencia en actividades diarias. Mi enfoque se centra en la atención personalizada y en encontrar soluciones prácticas que mejoren la calidad de vida de mis pacientes. Estoy emocionada de colaborar en proyectos que me permitan aplicar mis conocimientos y habilidades para ayudar a otros a alcanzar su máximo potencial. ¡Contáctame y comencemos juntos el camino hacia la recuperación y el bienestar!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_teresa.jpg"
},
new Resume
{
    UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b"),
    Description = "¡Hola! Soy José Manuel, un contador público con experiencia en auditoría y análisis financiero. Con más de 10 años de experiencia en el campo, he trabajado en una variedad de industrias, desde la banca hasta la consultoría. Mi enfoque se centra en proporcionar informes financieros precisos y estratégicos que ayuden a las empresas a tomar decisiones informadas y alcanzar sus objetivos financieros. Estoy comprometido con la excelencia en cada proyecto y estoy emocionado de poder contribuir con mi experiencia a tu equipo. ¡Contáctame y trabajemos juntos para impulsar el éxito financiero de tu empresa!",
    MinimumSalary = 90000,
    Image = "https://example.com/image_josemanuel.jpg"
},
new Resume
{
    UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5"),
    Description = "¡Hola! Soy Adriana Pérez, una diseñadora gráfica apasionada por la creación de identidades visuales impactantes y creativas. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos, desde el diseño de logotipos hasta campañas publicitarias completas. Mi enfoque se centra en entender las necesidades y objetivos de mis clientes para crear diseños únicos y memorables que comuniquen su mensaje de manera efectiva. Estoy emocionada de colaborar en proyectos que me permitan aplicar mi creatividad y experiencia para ayudar a las marcas a destacarse en un mercado competitivo. ¡Contáctame y hagamos magia juntos!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_adriana.jpg"
},
new Resume
{
    UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4"),
    Description = "¡Hola! Soy Francisco, un ingeniero de software con experiencia en el desarrollo de aplicaciones web y móviles. Con más de 6 años de experiencia en el campo, he trabajado en una variedad de proyectos, desde startups hasta grandes empresas. Mi enfoque se centra en la calidad del código, la escalabilidad y la seguridad de las soluciones que desarrollo. Estoy emocionado de contribuir con mi experiencia a tu equipo y ayudarte a alcanzar tus objetivos tecnológicos. ¡Juntos podemos construir soluciones innovadoras que impulsen tu negocio hacia el éxito!",
    MinimumSalary = 100000,
    Image = "https://example.com/image_francisco.jpg"
},
new Resume
{
    UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2"),
    Description = "¡Hola! Soy Mónica García, una psicóloga clínica comprometida con el bienestar emocional y mental de mis pacientes. Con más de 8 años de experiencia en el campo, he trabajado con personas de todas las edades y condiciones para ayudarles a superar desafíos emocionales y mejorar su calidad de vida. Mi enfoque se centra en la terapia cognitivo-conductual y en encontrar soluciones prácticas que promuevan el crecimiento personal y el bienestar emocional. Estoy emocionada de colaborar en proyectos que me permitan aplicar mis conocimientos y habilidades para ayudar a otros a vivir vidas más saludables y satisfactorias. ¡Contáctame y comencemos juntos el camino hacia el bienestar!",
    MinimumSalary = 85000,
    Image = "https://example.com/image_monica.jpg"
},
new Resume
{
    UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3"),
    Description = "¡Hola! Soy Víctor Morales, un periodista apasionado por contar historias y comunicar ideas de manera efectiva. Con más de 10 años de experiencia en la industria, he trabajado en una variedad de medios, desde periódicos locales hasta revistas nacionales. Mi enfoque se centra en la investigación exhaustiva y la redacción precisa para informar, educar y entretener a los lectores. Estoy emocionado de colaborar en proyectos que me permitan contar historias impactantes y generar un impacto positivo en la sociedad. ¡Contáctame y trabajemos juntos para dar vida a tus ideas y mensajes!",
    MinimumSalary = 75000,
    Image = "https://example.com/image_victor.jpg"
},
new Resume
{
    UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae"),
    Description = "¡Hola! Soy Carmen Flores, una enfermera dedicada y compasiva con una pasión por brindar atención de calidad a mis pacientes. Con más de 10 años de experiencia en el campo de la salud, he trabajado en una variedad de entornos, desde hospitales hasta centros de atención primaria. Mi enfoque se centra en el cuidado integral del paciente, brindando apoyo emocional y físico en cada etapa del proceso de atención médica. Estoy comprometida con la excelencia en el cuidado de la salud y estoy emocionada de colaborar en proyectos que mejoren la calidad de vida de las personas. ¡Contáctame y trabajemos juntos para hacer una diferencia en la vida de los demás!",
    MinimumSalary = 85000,
    Image = "https://example.com/image_carmen.jpg"
},
new Resume
{
    UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903"),
    Description = "¡Hola! Soy Luis Miguel, un contador con experiencia en la gestión financiera y la planificación fiscal. Con más de 8 años de experiencia en el campo, he trabajado en una variedad de industrias, desde la banca hasta la consultoría financiera. Mi enfoque se centra en proporcionar asesoramiento financiero estratégico que ayude a las empresas a alcanzar sus objetivos comerciales y financieros. Estoy comprometido con la integridad y la precisión en cada proyecto que emprendo y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y conocimientos. ¡Contáctame y trabajemos juntos para optimizar tus finanzas!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_luismiguel.jpg"
},
new Resume
{
    UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd"),
    Description = "¡Hola! Soy Beatriz, una diseñadora de moda apasionada por la creación de prendas únicas y elegantes. Con más de 6 años de experiencia en la industria, he trabajado en el diseño de ropa para diversas ocasiones, desde desfiles de moda hasta eventos exclusivos. Mi enfoque se centra en la combinación de creatividad y funcionalidad para crear colecciones que reflejen las últimas tendencias y satisfagan las necesidades de mis clientes. Estoy emocionada de colaborar en proyectos que me permitan expresar mi pasión por la moda y crear piezas que inspiren confianza y estilo. ¡Contáctame y hagamos realidad tus ideas de moda!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_beatriz.jpg"
},
new Resume
{
    UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b"),
    Description = "¡Hola! Soy Jorge, un ingeniero civil con experiencia en el diseño y la construcción de proyectos de infraestructura. Con más de 10 años de experiencia en el campo, he trabajado en una variedad de proyectos, desde carreteras hasta puentes y edificios. Mi enfoque se centra en la calidad, la seguridad y la eficiencia en cada proyecto que emprendo. Estoy comprometido con la excelencia en el diseño y la ejecución de proyectos que mejoren la calidad de vida de las personas. ¡Contáctame y trabajemos juntos para construir un futuro mejor!",
    MinimumSalary = 110000,
    Image = "https://example.com/image_jorge.jpg"
},
new Resume
{
    UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c"),
    Description = "¡Hola! Soy Fernando Gómez, un abogado especializado en derecho corporativo y empresarial. Con más de 8 años de experiencia en el campo, he asesorado a empresas en una variedad de asuntos legales, desde fusiones y adquisiciones hasta litigios comerciales. Mi enfoque se centra en proporcionar soluciones legales estratégicas que protejan los intereses de mis clientes y impulsen el crecimiento de sus negocios. Estoy comprometido con la excelencia en la práctica del derecho y estoy emocionado de colaborar en proyectos que me permitan aplicar mis conocimientos y habilidades para ayudar a las empresas a alcanzar sus objetivos comerciales. ¡Contáctame y trabajemos juntos para asegurar tu éxito empresarial!",
    MinimumSalary = 120000,
    Image = "https://example.com/image_fernando.jpg"
},
new Resume
{
    UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df"),
    Description = "¡Hola! Soy Alejandra Hernández, una ingeniera de software apasionada por la creación de soluciones innovadoras y eficientes. Con más de 6 años de experiencia en desarrollo de software, he trabajado en una variedad de proyectos, desde aplicaciones móviles hasta sistemas empresariales. Mi enfoque se centra en el diseño de software robusto y escalable que cumpla con los requisitos del cliente y supere sus expectativas. Estoy comprometida con la mejora continua y estoy emocionada de colaborar en proyectos que me desafíen y me permitan seguir aprendiendo y creciendo profesionalmente. ¡Contáctame y trabajemos juntos para impulsar la innovación!",
    MinimumSalary = 110000,
    Image = "https://example.com/image_alejandra.jpg"
},
new Resume
{
    UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b"),
    Description = "¡Hola! Soy Gustavo Martínez, un arquitecto con pasión por el diseño creativo y funcional. Con más de 8 años de experiencia en la industria de la construcción, he trabajado en una variedad de proyectos, desde viviendas unifamiliares hasta complejos comerciales. Mi enfoque se centra en la integración de la estética y la funcionalidad para crear espacios arquitectónicos que mejoren la calidad de vida de las personas. Estoy comprometido con la sostenibilidad y la innovación en el diseño y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y creatividad. ¡Contáctame y trabajemos juntos para hacer realidad tus sueños arquitectónicos!",
    MinimumSalary = 120000,
    Image = "https://example.com/image_gustavo.jpg"
},
new Resume
{
    UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3"),
    Description = "¡Hola! Soy Valeria González, una consultora de marketing digital apasionada por ayudar a las empresas a alcanzar su máximo potencial en línea. Con más de 5 años de experiencia en marketing digital, he trabajado con clientes de diversas industrias para desarrollar estrategias de marketing efectivas y alcanzar objetivos comerciales. Mi enfoque se centra en la generación de contenido relevante, la optimización de SEO y la gestión de campañas publicitarias en redes sociales. Estoy comprometida con la innovación y el crecimiento en el campo del marketing digital y estoy emocionada de colaborar en proyectos que me desafíen y me permitan seguir aprendiendo. ¡Contáctame y llevemos tu marca al siguiente nivel!",
    MinimumSalary = 100000,
    Image = "https://example.com/image_valeria.jpg"
},
new Resume
{
    UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c"),
    Description = "¡Hola! Soy Raúl Pérez, un contador público con experiencia en la gestión financiera y la planificación fiscal. Con más de 8 años de experiencia en el campo, he trabajado con una variedad de clientes, desde pequeñas empresas hasta corporaciones multinacionales. Mi enfoque se centra en proporcionar asesoramiento financiero estratégico que ayude a mis clientes a tomar decisiones informadas y alcanzar sus objetivos financieros. Estoy comprometido con la integridad y la precisión en mi trabajo y estoy emocionado de colaborar en proyectos que me permitan aplicar mis conocimientos y habilidades. ¡Contáctame y trabajemos juntos para optimizar tus finanzas!",
    MinimumSalary = 105000,
    Image = "https://example.com/image_raul.jpg"
},
new Resume
{
    UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633"),
    Description = "¡Hola! Soy Camila Sánchez, una psicóloga clínica comprometida con el bienestar emocional y mental de mis pacientes. Con más de 7 años de experiencia en el campo, he trabajado en una variedad de entornos, desde hospitales hasta consultorios privados. Mi enfoque se centra en proporcionar terapia individualizada y centrada en el paciente que aborde sus necesidades específicas y promueva el crecimiento personal. Estoy comprometida con la empatía y la compasión en mi práctica clínica y estoy emocionada de colaborar en proyectos que me permitan ayudar a las personas a superar sus desafíos emocionales y alcanzar su máximo potencial. ¡Contáctame y comencemos este viaje de autodescubrimiento juntos!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_camila.jpg"
},
new Resume
{
    UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a"),
    Description = "¡Hola! Soy Felipe López, un desarrollador web con una pasión por crear experiencias digitales excepcionales. Con más de 4 años de experiencia en el desarrollo de sitios web y aplicaciones, he trabajado en una variedad de proyectos, desde sitios de comercio electrónico hasta aplicaciones empresariales. Mi enfoque se centra en la usabilidad y el rendimiento, asegurándome de que cada proyecto cumpla con los más altos estándares de calidad. Estoy comprometido con el aprendizaje continuo y la mejora de mis habilidades y estoy emocionado de colaborar en proyectos innovadores que desafíen mis capacidades. ¡Contáctame y llevemos tu presencia en línea al siguiente nivel!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_felipe.jpg"
},
new Resume
{
    UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44"),
    Description = "¡Hola! Soy Natalia Ramírez, una diseñadora gráfica apasionada por la creación de soluciones visuales impactantes. Con más de 6 años de experiencia en diseño gráfico, he trabajado en una variedad de proyectos, desde identidades de marca hasta diseño editorial. Mi enfoque se centra en la creatividad y la atención al detalle, asegurándome de que cada diseño transmita el mensaje deseado de manera efectiva. Estoy comprometida con la innovación y la excelencia en mi trabajo y estoy emocionada de colaborar en proyectos que me permitan expresar mi creatividad y mejorar mis habilidades. ¡Contáctame y juntos crearemos diseños que inspiren y cautiven!",
    MinimumSalary = 90000,
    Image = "https://example.com/image_natalia.jpg"
},
new Resume
{
    UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2"),
    Description = "¡Hola! Soy Alberto García, un consultor financiero con una amplia experiencia en el análisis y la gestión de inversiones. Con más de 8 años de experiencia en el sector financiero, he trabajado con una variedad de clientes, desde individuos hasta corporaciones, para ayudarles a alcanzar sus objetivos financieros. Mi enfoque se centra en proporcionar asesoramiento personalizado que maximice el rendimiento de la inversión y minimice los riesgos. Estoy comprometido con la integridad y la transparencia en mi trabajo y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y conocimientos financieros. ¡Contáctame y trabajemos juntos para optimizar tu cartera de inversiones!",
    MinimumSalary = 120000,
    Image = "https://example.com/image_alberto.jpg"
},
new Resume
{
    UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7"),
    Description = "¡Hola! Soy Paola Díaz, una abogada comprometida con la justicia y la defensa de los derechos humanos. Con más de 7 años de experiencia en el campo del derecho, me especializo en derecho laboral y derecho civil. He representado con éxito a clientes en una variedad de casos, desde disputas laborales hasta reclamaciones de daños personales. Mi enfoque se centra en proporcionar asesoramiento legal compasivo y efectivo que resuelva los problemas de mis clientes de manera justa y equitativa. Estoy comprometida con la ética y la profesionalidad en mi práctica legal y estoy emocionada de colaborar en proyectos que promuevan la justicia y la igualdad. ¡Contáctame y trabajemos juntos para proteger tus derechos!",
    MinimumSalary = 110000,
    Image = "https://example.com/image_paola.jpg"
},
new Resume
{
    UserId = Guid.Parse("19d1cc4c-18e4-42fc-9cbd-56253b20165e"),
    Description = "¡Hola! Soy Claudia Ramírez, una enfermera comprometida con la prestación de atención médica de alta calidad y compasiva. Con más de 5 años de experiencia en enfermería, he trabajado en una variedad de entornos, desde hospitales hasta centros de atención a largo plazo. Mi enfoque se centra en el bienestar holístico de mis pacientes, brindando atención centrada en el paciente que aborde tanto sus necesidades físicas como emocionales. Estoy comprometida con la excelencia en la atención médica y estoy emocionada de colaborar en proyectos que me permitan hacer una diferencia positiva en la vida de las personas. ¡Contáctame y juntos promoveremos la salud y el bienestar!",
    MinimumSalary = 100000,
    Image = "https://example.com/image_claudia.jpg"
},
new Resume
{
    UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d"),
    Description = "¡Hola! Soy Ricardo Morales, un ingeniero mecánico con experiencia en el diseño y la fabricación de sistemas mecánicos innovadores. Con más de 8 años de experiencia en la industria, he trabajado en una variedad de proyectos, desde automoción hasta energía renovable. Mi enfoque se centra en la eficiencia y la sostenibilidad, diseñando sistemas que sean tanto funcionales como respetuosos con el medio ambiente. Estoy comprometido con la excelencia en el diseño y la ingeniería y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y conocimientos. ¡Contáctame y trabajemos juntos para impulsar la innovación en la industria!",
    MinimumSalary = 130000,
    Image = "https://example.com/image_ricardo.jpg"
},
new Resume
{
    UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f"),
    Description = "¡Hola! Soy Rosa González, una profesional de recursos humanos con una pasión por reclutar y retener el mejor talento. Con más de 7 años de experiencia en reclutamiento, he trabajado en una variedad de sectores, desde tecnología hasta servicios financieros. Mi enfoque se centra en entender las necesidades de la empresa y encontrar candidatos que no solo tengan las habilidades necesarias, sino que también se ajusten a la cultura organizacional. Estoy comprometida con la equidad y la diversidad en el lugar de trabajo y estoy emocionada de colaborar en proyectos que promuevan un ambiente laboral inclusivo y acogedor. ¡Contáctame y llevemos tu equipo al siguiente nivel!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_rosa.jpg"
},
new Resume
{
    UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea"),
    Description = "¡Hola! Soy Ignacio, un desarrollador de software apasionado por la creación de soluciones tecnológicas innovadoras. Con más de 5 años de experiencia en desarrollo de software, he trabajado en una variedad de proyectos, desde aplicaciones móviles hasta sistemas de gestión empresarial. Mi enfoque se centra en la calidad del código y la usabilidad del producto, asegurándome de que cada aplicación sea intuitiva y fácil de usar. Estoy comprometido con el aprendizaje continuo y la mejora de mis habilidades y estoy emocionado de colaborar en proyectos que desafíen mi capacidad de innovación. ¡Contáctame y trabajemos juntos para crear software que marque la diferencia!",
    MinimumSalary = 100000,
    Image = "https://example.com/image_ignacio.jpg"
},
new Resume
{
    UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819"),
    Description = "¡Hola! Soy Andrea Ramírez, una diseñadora de moda con una pasión por la creatividad y la expresión artística. Con más de 8 años de experiencia en la industria de la moda, he trabajado en una variedad de roles, desde diseño de prendas hasta dirección de arte. Mi enfoque se centra en la innovación y la sostenibilidad, creando colecciones que sean tanto visualmente impactantes como éticamente responsables. Estoy comprometida con la inclusión y la diversidad en la moda y estoy emocionada de colaborar en proyectos que celebren la individualidad y la autenticidad. ¡Contáctame y juntos crearemos moda que inspire y empodere!",
    MinimumSalary = 110000,
    Image = "https://example.com/image_andrea.jpg"
},
new Resume
{
    UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21"),
    Description = "¡Hola! Soy Víctor García, un contador público certificado con una amplia experiencia en contabilidad financiera y gestión fiscal. Con más de 10 años de experiencia en contabilidad, he trabajado en una variedad de industrias, desde servicios profesionales hasta manufactura. Mi enfoque se centra en la precisión y la integridad de los datos financieros, asegurándome de que cada informe sea exacto y cumpla con las normativas vigentes. Estoy comprometido con la excelencia en la contabilidad y estoy emocionado de colaborar en proyectos que me permitan aplicar mi experiencia y conocimientos. ¡Contáctame y trabajemos juntos para optimizar tus operaciones financieras!",
    MinimumSalary = 120000,
    Image = "https://example.com/image_victor.jpg"
},
new Resume
{
    UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2"),
    Description = "¡Hola! Soy Lorena Díaz, una consultora de marketing digital con una pasión por ayudar a las empresas a alcanzar su máximo potencial en línea. Con más de 6 años de experiencia en marketing digital, he trabajado con una variedad de clientes, desde startups hasta empresas consolidadas. Mi enfoque se centra en la estrategia y la ejecución, desarrollando campañas que generen resultados tangibles y aumenten la visibilidad de la marca. Estoy comprometida con la innovación y la creatividad en el marketing y estoy emocionada de colaborar en proyectos que desafíen mis habilidades y conocimientos. ¡Contáctame y llevemos tu estrategia de marketing al siguiente nivel!",
    MinimumSalary = 130000,
    Image = "https://example.com/image_lorena.jpg"
},
new Resume
{
    UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49"),
    Description = "¡Hola! Soy Carlos Hernández, un arquitecto apasionado por el diseño sostenible y la planificación urbana. Con más de 8 años de experiencia en arquitectura, he trabajado en una variedad de proyectos, desde viviendas unifamiliares hasta grandes desarrollos urbanos. Mi enfoque se centra en la integración de prácticas sostenibles en el diseño arquitectónico, creando espacios que sean tanto estéticamente atractivos como respetuosos con el medio ambiente. Estoy comprometido con la mejora de la calidad de vida en las ciudades y estoy emocionado de colaborar en proyectos que promuevan un desarrollo urbano sostenible. ¡Contáctame y juntos diseñemos el futuro de nuestras ciudades!",
    MinimumSalary = 140000,
    Image = "https://example.com/image_carlos.jpg"
},
new Resume
{
    UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e"),
    Description = "¡Hola! Soy Miriam López, una periodista apasionada por contar historias que inspiren y conecten con la audiencia. Con más de 5 años de experiencia en medios de comunicación, he cubierto una variedad de temas, desde política hasta cultura. Mi enfoque se centra en la investigación y la narración, buscando siempre la verdad y la objetividad en mis reportajes. Estoy comprometida con el periodismo ético y estoy emocionada de colaborar en proyectos que informen y empoderen a la sociedad. ¡Contáctame y juntos contemos la próxima gran historia!",
    MinimumSalary = 75000,
    Image = "https://example.com/image_miriam.jpg"
},
new Resume
{
    UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2"),
    Description = "¡Hola! Soy Marcos Pérez, un ingeniero de software con una pasión por la tecnología y la innovación. Con más de 8 años de experiencia en desarrollo de software, he trabajado en una variedad de proyectos, desde aplicaciones móviles hasta sistemas de gestión empresarial. Mi enfoque se centra en la calidad del código y la eficiencia del producto, asegurándome de que cada aplicación cumpla con los más altos estándares de rendimiento y seguridad. Estoy comprometido con el aprendizaje continuo y la mejora de mis habilidades y estoy emocionado de colaborar en proyectos que desafíen mi capacidad de innovación. ¡Contáctame y llevemos tu proyecto al siguiente nivel!",
    MinimumSalary = 85000,
    Image = "https://example.com/image_marcos.jpg"
},
new Resume
{
    UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885"),
    Description = "¡Hola! Soy Patricia Flores, una psicóloga clínica con una pasión por ayudar a las personas a alcanzar su máximo potencial. Con más de 10 años de experiencia en psicoterapia, he trabajado con una variedad de clientes, desde niños hasta adultos mayores. Mi enfoque se centra en el bienestar emocional y el crecimiento personal, ofreciendo un enfoque integrador que combine diferentes técnicas terapéuticas. Estoy comprometida con la salud mental y el bienestar y estoy emocionada de colaborar en proyectos que promuevan el desarrollo humano. ¡Contáctame y juntos trabajemos para mejorar tu calidad de vida!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_patricia.jpg"
},
new Resume
{
    UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb"),
    Description = "¡Hola! Soy Juliana González, una diseñadora gráfica con una pasión por la creatividad y la innovación. Con más de 6 años de experiencia en diseño gráfico, he trabajado en una variedad de proyectos, desde identidad corporativa hasta diseño editorial. Mi enfoque se centra en la estética y la funcionalidad, creando diseños que sean tanto visualmente impactantes como efectivos en la comunicación. Estoy comprometida con la excelencia en el diseño y estoy emocionada de colaborar en proyectos que desafíen mi creatividad. ¡Contáctame y juntos crearemos diseños que marquen la diferencia!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_juliana.jpg"
},
new Resume
{
    UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241"),
    Description = "¡Hola! Soy Roberto López, un abogado especializado en derecho laboral con una pasión por la justicia y la equidad en el trabajo. Con más de 7 años de experiencia en derecho laboral, he representado a trabajadores y empleadores en una variedad de casos, desde despidos injustificados hasta conflictos sindicales. Mi enfoque se centra en la defensa de los derechos laborales y la resolución eficiente de conflictos, buscando siempre alcanzar acuerdos justos para todas las partes involucradas. Estoy comprometido con la defensa de los derechos humanos y estoy emocionado de colaborar en proyectos que promuevan un ambiente laboral justo y equitativo. ¡Contáctame y juntos defendamos tus derechos!",
    MinimumSalary = 90000,
    Image = "https://example.com/image_roberto.jpg"
},
new Resume
{
    UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e"),
    Description = "¡Hola! Soy María, una diseñadora de moda apasionada por la creatividad y la innovación en la industria textil. Con más de 5 años de experiencia en diseño de moda, he trabajado en una variedad de proyectos, desde colecciones de prêt-à-porter hasta diseños personalizados. Mi enfoque se centra en la combinación de estilos tradicionales y contemporáneos, creando prendas que sean tanto elegantes como funcionales. Estoy comprometida con la sostenibilidad en la moda y estoy emocionada de colaborar en proyectos que promuevan prácticas éticas en la industria. ¡Contáctame y juntos creemos diseños que marquen tendencia!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_maria.jpg"
},
new Resume
{
    UserId = Guid.Parse("80120fd9-ade7-4cd0-9dda-7b733e02d7cd"),
    Description = "¡Hola! Soy Carlos, un desarrollador web con una pasión por la creación de experiencias digitales innovadoras. Con más de 8 años de experiencia en desarrollo web, he trabajado en una variedad de proyectos, desde sitios web corporativos hasta aplicaciones web complejas. Mi enfoque se centra en la usabilidad y el rendimiento, asegurándome de que cada proyecto cumpla con los más altos estándares de calidad. Estoy comprometido con la mejora continua y estoy emocionado de colaborar en proyectos que desafíen mis habilidades técnicas. ¡Contáctame y llevemos tu presencia en línea al siguiente nivel!",
    MinimumSalary = 90000,
    Image = "https://example.com/image_carlos.jpg"
},
new Resume
{
    UserId = Guid.Parse("0e5a9aab-eb68-4ca9-8b80-ea7bef076946"),
    Description = "¡Hola! Soy Laura, una investigadora científica apasionada por la exploración del universo y la comprensión de sus misterios. Con más de 10 años de experiencia en astronomía, he contribuido a una variedad de proyectos de investigación, desde el estudio de exoplanetas hasta la exploración del cosmos distante. Mi enfoque se centra en la astrofísica y la cosmología, buscando respuestas a preguntas fundamentales sobre el origen y la evolución del universo. Estoy comprometida con la divulgación científica y estoy emocionada de colaborar en proyectos que acerquen la ciencia a la sociedad. ¡Contáctame y exploremos juntos los secretos del universo!",
    MinimumSalary = 100000,
    Image = "https://example.com/image_laura.jpg"
},
new Resume
{
    UserId = Guid.Parse("0b450794-1b65-4d42-8df7-05b57b970454"),
    Description = "¡Hola! Soy José, un contador público con una pasión por los números y el análisis financiero. Con más de 7 años de experiencia en contabilidad y finanzas, he trabajado en una variedad de roles, desde auditoría hasta consultoría fiscal. Mi enfoque se centra en la precisión y la integridad de la información financiera, asegurando el cumplimiento de las normativas y la optimización de los recursos financieros. Estoy comprometido con la excelencia en la gestión financiera y estoy emocionado de colaborar en proyectos que impulsen el crecimiento económico. ¡Contáctame y juntos aseguremos el éxito financiero de tu empresa!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_jose.jpg"
},
new Resume
{
    UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730"),
    Description = "¡Hola! Soy Ana, una fotógrafa profesional con una pasión por capturar momentos memorables y contar historias a través de imágenes. Con más de 6 años de experiencia en fotografía, he trabajado en una variedad de proyectos, desde sesiones de retratos hasta cobertura de eventos especiales. Mi enfoque se centra en la creatividad y la sensibilidad artística, buscando siempre la belleza y el significado en cada fotografía. Estoy comprometida con la excelencia técnica y estoy emocionada de colaborar en proyectos que celebren la diversidad y la creatividad visual. ¡Contáctame y juntos creemos imágenes que perduren para siempre!",
    MinimumSalary = 85000,
    Image = "https://example.com/image_ana.jpg"
},
new Resume
{
    UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd"),
    Description = "¡Hola! Soy Pedro, un ingeniero de software con una pasión por la programación y el desarrollo de aplicaciones innovadoras. Con más de 5 años de experiencia en desarrollo de software, he trabajado en una variedad de proyectos, desde aplicaciones móviles hasta sistemas de gestión empresarial. Mi enfoque se centra en la calidad del código y la eficiencia del desarrollo, asegurándome de que cada producto cumpla con los más altos estándares de rendimiento y usabilidad. Estoy comprometido con la mejora continua y estoy emocionado de colaborar en proyectos que desafíen mis habilidades técnicas. ¡Contáctame y llevemos tus ideas al siguiente nivel!",
    MinimumSalary = 90000,
    Image = "https://example.com/image_pedro.jpg"
},
new Resume
{
    UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9"),
    Description = "¡Hola! Soy Isabel, una escritora apasionada por las palabras y las historias que cuentan. Con más de 8 años de experiencia en redacción y edición, he trabajado en una variedad de proyectos editoriales, desde novelas hasta artículos periodísticos. Mi enfoque se centra en la claridad y la expresión creativa, buscando siempre transmitir mensajes significativos y emocionantes. Estoy comprometida con la excelencia en la escritura y estoy emocionada de colaborar en proyectos que inspiren y entretengan a los lectores. ¡Contáctame y juntos creemos historias que perduren para siempre!",
    MinimumSalary = 85000,
    Image = "https://example.com/image_isabel.jpg"
},
new Resume
{
    UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16"),
    Description = "¡Hola! Soy David, un diseñador gráfico con una pasión por la creatividad y la expresión visual. Con más de 6 años de experiencia en diseño gráfico, he trabajado en una variedad de proyectos, desde branding corporativo hasta diseño de interfaces de usuario. Mi enfoque se centra en la estética y la funcionalidad, buscando siempre encontrar el equilibrio perfecto entre la forma y la función. Estoy comprometido con la innovación en el diseño y estoy emocionado de colaborar en proyectos que desafíen mi creatividad. ¡Contáctame y llevemos tu marca al siguiente nivel visual!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_david.jpg"
},
new Resume
{
    UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da"),
    Description = "¡Hola! Soy Mónica, una consultora de marketing digital con una pasión por conectar marcas con su audiencia en línea. Con más de 7 años de experiencia en marketing digital, he trabajado en una variedad de proyectos, desde campañas de redes sociales hasta estrategias de SEO. Mi enfoque se centra en la segmentación del mercado y la personalización del mensaje, buscando siempre maximizar el impacto de cada acción de marketing. Estoy comprometida con la innovación en el marketing digital y estoy emocionada de colaborar en proyectos que impulsen el crecimiento de las marcas. ¡Contáctame y llevemos tu presencia en línea al siguiente nivel!",
    MinimumSalary = 100000,
    Image = "https://example.com/image_monica.jpg"
},
new Resume
{
    UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423"),
    Description = "¡Hola! Soy Fernando, un chef apasionado por la gastronomía y la creación de experiencias culinarias memorables. Con más de 10 años de experiencia en la industria de la restauración, he trabajado en una variedad de cocinas, desde la cocina tradicional hasta la alta cocina. Mi enfoque se centra en la calidad de los ingredientes y la innovación en la presentación, buscando siempre sorprender y deleitar a los comensales. Estoy comprometido con la excelencia en la cocina y estoy emocionado de colaborar en proyectos que celebren la diversidad gastronómica. ¡Contáctame y juntos creemos platos que despierten tus sentidos!",
    MinimumSalary = 110000,
    Image = "https://example.com/image_fernando.jpg"
},
new Resume
{
    UserId = Guid.Parse("1cdb46ef-e0a5-427c-8409-9a58cde54ce9"),
    Description = "¡Hola! Soy Luis, un desarrollador web con una pasión por la creación de sitios web dinámicos y funcionales. Con más de 4 años de experiencia en desarrollo web, tengo habilidades sólidas en HTML, CSS, JavaScript y frameworks como React y Angular. Mi enfoque se centra en la usabilidad y la experiencia del usuario, buscando siempre crear interfaces intuitivas y atractivas. Estoy comprometido con la mejora continua y estoy emocionado de colaborar en proyectos que desafíen mis habilidades técnicas. ¡Contáctame y construyamos la próxima gran experiencia web juntos!",
    MinimumSalary = 80000,
    Image = "https://example.com/image_luis.jpg"
},
new Resume
{
    UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6"),
    Description = "¡Hola! Soy Carmen, una diseñadora gráfica apasionada por la creatividad y la expresión visual. Con más de 6 años de experiencia en diseño gráfico, he trabajado en una variedad de proyectos, desde branding corporativo hasta diseño editorial. Mi enfoque se centra en la estética y la comunicación visual, buscando siempre transmitir mensajes claros y emocionantes. Estoy comprometida con la innovación en el diseño y estoy emocionada de colaborar en proyectos que desafíen mi creatividad. ¡Contáctame y llevemos tus ideas al siguiente nivel visual!",
    MinimumSalary = 85000,
    Image = "https://example.com/image_carmen.jpg"
},
new Resume
{
    UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7"),
    Description = "¡Hola! Soy Pablo, un consultor de marketing digital con una pasión por ayudar a las marcas a alcanzar su máximo potencial en línea. Con más de 5 años de experiencia en marketing digital, he trabajado en una variedad de proyectos, desde estrategias de redes sociales hasta campañas de PPC. Mi enfoque se centra en la analítica y la optimización, buscando siempre maximizar el ROI de cada acción de marketing. Estoy comprometido con la excelencia en el marketing digital y estoy emocionado de colaborar en proyectos que impulsen el crecimiento de las marcas. ¡Contáctame y llevemos tu estrategia digital al siguiente nivel!",
    MinimumSalary = 90000,
    Image = "https://example.com/image_pablo.jpg"
},
new Resume
{
    UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002"),
    Description = "¡Hola! Soy Elena, una fotógrafa profesional con una pasión por capturar momentos inolvidables. Con más de 8 años de experiencia en fotografía, he trabajado en una variedad de proyectos, desde retratos hasta fotografía de eventos. Mi enfoque se centra en la creatividad y la composición, buscando siempre crear imágenes que cuenten una historia única. Estoy comprometida con la excelencia en la fotografía y estoy emocionada de colaborar en proyectos que celebren la belleza del mundo que nos rodea. ¡Contáctame y juntos capturemos momentos que perduren para siempre!",
    MinimumSalary = 95000,
    Image = "https://example.com/image_elena.jpg"
},
new Resume
{
    UserId = Guid.Parse("153ff2f4-ccb7-43b1-b163-8f995adb1d13"),
    Description = "¡Hola! Soy Diego, un ingeniero civil con una pasión por el diseño y la construcción de infraestructuras innovadoras. Con más de 7 años de experiencia en ingeniería civil, he trabajado en una variedad de proyectos, desde edificios residenciales hasta carreteras y puentes. Mi enfoque se centra en la sostenibilidad y la eficiencia, buscando siempre soluciones que mejoren la calidad de vida de las personas y respeten el medio ambiente. Estoy comprometido con la excelencia en la ingeniería y estoy emocionado de colaborar en proyectos que transformen el mundo que nos rodea. ¡Contáctame y construyamos un futuro mejor juntos!",
    MinimumSalary = 100000,
    Image = "https://example.com/image_diego.jpg"
},
new Resume
{
    UserId = Guid.Parse("7c5891f9-9fac-4dbf-9afd-2c9e01759e20"),
    Description = "¡Hola! Soy Alejandra, una escritora independiente con una pasión por contar historias cautivadoras. Con más de 4 años de experiencia en escritura creativa, he trabajado en una variedad de proyectos, desde novelas hasta guiones y artículos de blog. Mi enfoque se centra en la emoción y la autenticidad, buscando siempre conectar con los lectores a un nivel profundo. Estoy comprometida con la excelencia en la escritura y estoy emocionada de colaborar en proyectos que inspiren y entretengan a las personas. ¡Contáctame y juntos creemos historias que perduren para siempre!",
    MinimumSalary = 85000,
    Image = "https://example.com/image_alejandra.jpg"
}


















                );
        }
    }
}