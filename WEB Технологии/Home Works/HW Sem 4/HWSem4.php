<?php
$name = 'Андрей';
$profession = 'Тестировщик';
$city_country = 'Санкт-Петербург, Россия';
$email = 'siriusdei@mail.ru';
$number = '8 800 555 35 35';                                        #P.S Изменил шкалу языков, подрубил Ваш любимый шрифт Montserrat.                                                              
function AgeToDays() #Func on 115 row                               #Сделал функцию для подсчёта и вывода возраста.
{
    $age = 28;
    $ageInDays = $age * 365;
    echo "$age лет ($ageInDays дней)";
}

$skillsArray = [
    'photoshop' => '97%',
    'photography' => '83%',
    'illustrator' => '70%',
    'media' => '80%'
];

$languages = [
    'English' => '50%',
    'Spain' => '0%',
    'German' => '0%'
];

#region Альтернативное решение
// $workDates = [
//     'TRIGO' => 'Июнь 2020 - Апрель 2022',
//     'Rucotec' => 'Июль 2018 - Июнь 2020',
//     'Кд Строй' => 'Июль 2012 - Август 2019'
// ];
// $workPosition=[
//     'TRIGO'=>'Оператор контроля качества',
//     'RUCOTEC'=>'Оператор контроля качества',
//     'Кд строй'=>'Старший маляр'
// ];
// $workDuties = [
//     'TRIGO'=>'Оценка и контроль качества автокомпонентов',
//     'Rucotec'=>'Оценка и контроль качества автокомпонентов',
//     'Кд Строй'=>'Оценка и контроль качества покрасочных работ в цеху'
// ];
#endregion

$MyWork = [
    'TRIGO' => [
        'workDates' => 'Июнь 2020 - Апрель 2022',
        'workPosition' => 'Оператор контроля качества "TRIGO"',
        'workDuties' => 'Оценка и контроль качества автокомпонентов.'
    ],
    'Rucotec' => [
        'workDates' => 'Июль 2018 - Июнь 2020',
        'workPosition' => 'Оператор контроля качества "Rucotec"',
        'workDuties' => 'Оценка и контроль качества автокомпонентов.'
    ],
    'Кд Строй' => [
        'workDates' => 'Июль 2015 - Июль 2018',
        'workPosition' => 'Старший маляр "Кд Строй"',
        'workDuties' => 'Оценка и контроль качества покрасочных работ в цеху. Контроль работы сотрудников покрасочного участка.
        Участие в инвентаризациях, тестирование нового оборудования. Составление отчетов и табелей.'
    ]

]

?>

<!DOCTYPE html>
<html>

<head>
    <title>Мое резюме</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.google.com/share?selection.family=Montserrat:wght@500" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <script type="text/javascript" src="https://me.kis.v2.scr.kaspersky-labs.com/FD126C42-EBFA-4E12-B309-BB3FDD723AC1/main.js?attr=8E1dQu4RR3p80WF7IGsr9Rdr22mCOCPZad8K7bjfVaL-0aIahkkgCl4aumpk91u4wmg4adw1VOnBEy5xk210HHXWDoBs-uQjgPzywZpIUGatmbGWVN3ROL_c5-rA3C3u2n1B3HemxUWHfeap9cuq0pyS13UqvrfnEm8K2MVwOZDscJFpujLEytDix8loqU6SzUUZ497yRUwbkHQnL2XUZvbLq7Os2b-TxF-ctfQE-4bNsJtAaRGOPZf7ei6HI5hzsDZRiYmxA0J2-PUvcmSKgyXM7CnYltaozMZb9QCHfeSkqHhSigH0yurLeAq7miiajcrOU5UpJQLM1y8YA2CbtCnJrcn_a2uyRjwa3q1LP9Y5zW7fUU8UjMuWA_32tO_zSAdrmObFb58RPadHjSX4g9sUD7vWCJxKHes3JFCnNn_VUcZp2f06p1SwnB9OGLoeuFXty0C5wqGufNTYI4HyLXhErFw6285K2F-_MREH2tHnCfPTik14xV9GUbxLzPBpCvXzMD2ypp_bVdaSH4cRPl69-eT_-OidjIrD6uLURZI_ND0IKl8GI7YurJwD0h90Mti0YR3dw3NgDTGuELx63FepRK7ZEShD702tYlBiWY3yieDl8bM3VdfB9p4859jkvTOj0Ha3Iw8o-zGVVBhMfNZd_NGbGjR3zUpT3fBbhoYirLag2e_h9CmxDEFSgpwzgP4AJ0-5lGq5qbChSsbKUIJa9iYkFpuhxxc3FKhkPpjYR93f1Tlq_u7dFI2sg4UjjcESFIWbnQey0bbceqw_ktfWwjQwpuQWcwopY7a3j3xMekXfcEwBXmbNWLHbdn0Pi4ez7FO5A5cTbo_bhXg5bLl_s5E_Ar27vuaR5e9qnLirrfi2uxKWoJhOCUHom6ZM09DtRzK07giQqJwYOuBnpSCj-dekMvlhfEJKNl0eRnGm7XsaLVlePvGePeuK7DRJ9-FZGjiUq_B0grkNM9k8Y26v4SbDrcpeWZZh1juuiBc5ARmiZ5gUi6TOsKY97jRAyTMqJDsQPRgRNnz30XUy7Su_7m99lpe3w-W5pv6-90A" charset="UTF-8"></script>
    <style>
        html,
        body,
        h1,
        h2,
        h3,
        h4,
        h5,
        h6 {
            font-family: 'Jost', sans-serif;
        }
    </style>
</head>

<body class="w3-light-grey">

    <!-- Page Container -->
    <div class="w3-content w3-margin-top" style="max-width:1400px;">

        <!-- The Grid -->
        <div class="w3-row-padding">

            <!-- Left Column -->
            <div class="w3-third">

                <div class="w3-white w3-text-grey w3-card-4">
                    <div class="w3-display-container">
                        <img src="https://imgfon.ru/Images/Details_img_880px/Animals/glaza-belyy_fon-kotik-morda-polosatyy.webp" style="width:100%" alt="Avatar">
                        <div class="w3-display-bottomleft w3-container w3-text-black">
                            <h2><?php echo $name ?></h2>
                        </div>
                    </div>
                    <div class="w3-container">
                        <p><i class="fa fa-briefcase fa-fw w3-margin-right w3-large w3-text-teal"></i><?php echo $profession ?></p>
                        <p><i class="fa fa-home fa-fw w3-margin-right w3-large w3-text-teal"></i><?php echo $city_country ?></p>
                        <p><i class="fa fa-envelope fa-fw w3-margin-right w3-large w3-text-teal"></i><?php echo $email ?></p>
                        <p><i class="fa fa-phone fa-fw w3-margin-right w3-large w3-text-teal"></i><?php echo $number ?></p>
                        <p><i class="fa fa-hourglass fa-fw w3-margin-right w3-large w3-text-teal"></i><?php AgeToDays() ?></p>
                        <hr>

                        <p class="w3-large"><b><i class="fa fa-asterisk fa-fw w3-margin-right w3-text-teal"></i>Навыки</b></p>
                        <p>Adobe Photoshop</p>
                        <div class="w3-light-grey w3-round-xlarge w3-small">
                            <div class="w3-container w3-center w3-round-xlarge w3-teal" style="width:<?php echo $skillsArray['photoshop']; ?>"><?php echo $skillsArray['photoshop']; ?></div>
                        </div>
                        <p>Фотография</p>
                        <div class="w3-light-grey w3-round-xlarge w3-small">
                            <div class="w3-container w3-center w3-round-xlarge w3-teal" style="width:<?php echo $skillsArray['photography']; ?>">
                                <div class="w3-center w3-text-white"><?php echo $skillsArray['photography']; ?></div>
                            </div>
                        </div>
                        <p>Illustrator</p>
                        <div class="w3-light-grey w3-round-xlarge w3-small">
                            <div class="w3-container w3-center w3-round-xlarge w3-teal" style="width:<?php echo $skillsArray['illustrator']; ?>"><?php echo $skillsArray['illustrator']; ?></div>
                        </div>
                        <p>Копирайтинг</p>
                        <div class="w3-light-grey w3-round-xlarge w3-small">
                            <div class="w3-container w3-center w3-round-xlarge w3-teal" style="width:<?php echo $skillsArray['media']; ?>"><?php echo $skillsArray['media']; ?></div>
                        </div>
                        <br>

                        <p class="w3-large w3-text-theme"><b><i class="fa fa-globe fa-fw w3-margin-right w3-text-teal"></i>Языки</b></p>
                        <p>Английский</p>
                        <div class="w3-light-grey w3-round-xlarge">
                            <div class="w3-round-xlarge w3-teal" style="height:24px;width:<?php echo $languages['English']; ?>"></div>
                        </div>
                        <p>Испанский</p>
                        <div class="w3-light-grey w3-round-xlarge">
                            <div class="w3-round-xlarge w3-teal" style="height:24px;width:<?php echo $languages['Spain']; ?>"></div>
                        </div>
                        <p>Немецкий</p>
                        <div class="w3-light-grey w3-round-xlarge">
                            <div class="w3-round-xlarge w3-teal" style="height:24px;width:<?php echo $languages['German']; ?>"></div>
                        </div>
                        <br>
                    </div>
                </div><br>

                <!-- End Left Column -->
            </div>

            <!-- Right Column -->
            <div class="w3-twothird">

                <div class="w3-container w3-card w3-white w3-margin-bottom">
                    <h2 class="w3-text-grey w3-padding-16"><i class="fa fa-suitcase fa-fw w3-margin-right w3-xxlarge w3-text-teal"></i>Мой опыт работы</h2>
                    <div class="w3-container">
                        <h5 class="w3-opacity"><b><?php echo $MyWork['TRIGO']['workPosition']; ?></b></h5>
                        <h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i><?php echo $MyWork['TRIGO']['workDates']; ?></span></h6>
                        <p><?php echo $MyWork['TRIGO']['workDuties']; ?></p>
                        <hr>
                    </div>
                    <div class="w3-container">
                        <h5 class="w3-opacity"><b><?php echo $MyWork['Rucotec']['workPosition']; ?></b></h5>
                        <h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i><?php echo $MyWork['Rucotec']['workDates']; ?></h6>
                        <p><?php echo $MyWork['Rucotec']['workDuties']; ?></p>
                        <hr>
                    </div>
                    <div class="w3-container">
                        <h5 class="w3-opacity"><b><?php echo $MyWork['Кд Строй']['workPosition']; ?></b></h5>
                        <h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i><?php echo $MyWork['Кд Строй']['workDates']; ?></h6>
                        <p><?php echo $MyWork['Кд Строй']['workDuties']; ?></p><br>
                    </div>
                </div>

                <div class="w3-container w3-card w3-white">
                    <h2 class="w3-text-grey w3-padding-16"><i class="fa fa-certificate fa-fw w3-margin-right w3-xxlarge w3-text-teal"></i>Образование</h2>
                    <div class="w3-container">
                        <h5 class="w3-opacity"><b>gb.ru</b></h5>
                        <h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i>Forever</h6>
                        <p>Web Development! All I need to know in one place</p>
                        <hr>
                    </div>
                    <div class="w3-container">
                        <h5 class="w3-opacity"><b>London Business School</b></h5>
                        <h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i>2013 - 2015</h6>
                        <p>Master Degree</p>
                        <hr>
                    </div>
                    <div class="w3-container">
                        <h5 class="w3-opacity"><b>School of Coding</b></h5>
                        <h6 class="w3-text-teal"><i class="fa fa-calendar fa-fw w3-margin-right"></i>2010 - 2013</h6>
                        <p>Bachelor Degree</p><br>
                    </div>
                </div>

                <!-- End Right Column -->
            </div>

            <!-- End Grid -->
        </div>

        <!-- End Page Container -->
    </div>

    <!-- Footer -->
    <footer class="w3-container w3-teal w3-center w3-margin-top">
        <p>Find me on social media.</p>
        <i class="fa fa-pinterest-p w3-hover-opacity"></i>
        <i class="fa fa-twitter w3-hover-opacity"></i>
        <i class="fa fa-linkedin w3-hover-opacity"></i>
        <!-- End footer -->
    </footer>

</body>

</html>