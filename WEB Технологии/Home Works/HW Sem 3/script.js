function GetName(){
    alert("Привет! Давай познакомимся!")
    let firstName = prompt("Как тебя зовут?");
    let secondName = prompt("А твоя фамилия?");
    alert(`Рад познакомиться ${secondName} ${firstName} !`);
}
GetName();

function FavFilm(){
    let FavFilm = prompt("Расскажи как называется твой любимый фильм");
    switch(FavFilm){
        case "Эквилибриум":alert("Ого! Мой тоже!");break;
        case "Зелёная миля":alert("Я устал босс...");break;
        case "Побег из Шоушенка":alert("Да, классный");break;
        case "Бегущий по лезвию":alert("Один из последних, что я посмотрел.");break;
        case "Гарри Поттер":alert("Ну он то всем нравится :)");break;
        case "Константин":alert("Фильм детства, обожаю *0*");break;
        default:alert("Попробуйте ещё раз");
    }
    alert("Было приятно пообщаться, удачи!")
}
FavFilm();
