using System;

class Program
{
	public static void Main(string[] args)
	{
		//Создаем кортеж
		(string nameUser, string secondNameUser, int age,
			string[] namesPets, string[] namesFavorsColors
			) infoUser = new("", "", 0, new string[0], new string[0]);

		//Запускаем метод спроса информации у пользователя
		infoUser = GetInfoUser();

		//Отображаем всю информацию на консоль
		ShowInfoUser(infoUser);

	}
	public static (string nameUser, string secondNameUser, int age, string[] namesPets, string[] namesFavorsColors
			) GetInfoUser ()
    {
		(string nameUser, string secondNameUser, int age,
			string[] namesPets, string[] namesFavorsColors
			) infoUser = new ("", "", 0, new string[0], new string[0]);
		//Заполняем имя
		Console.WriteLine("Введите свое имя!");
		CheckValueString(Console.ReadLine(), out string valueName, "Не удалось определить Ваше имя! Укажите свое имя еще раз!");
		infoUser.nameUser = valueName;

		//Заполняем фамилию
		Console.WriteLine("Введите свою фамилию!");
		CheckValueString(Console.ReadLine(), out string valueSecondName, "Не удалось определить Вашу фамилию! Укажите ее еще раз!");
		infoUser.secondNameUser = valueSecondName;

		//Заполняем возраст
		Console.WriteLine("Укажите свой возраст!");
		CheckValueInt(Console.ReadLine(), out int age, "Не удалось определить Ваш возраст! Укажите свой возраст еще раз!");
		infoUser.age = age;

		//Спрашиваем про наличие животных
		Console.WriteLine("У вас есть домашние животные?Да/Нет");
		if(CheckValueBool(Console.ReadLine(), out bool result, "Не удалось определить Ваш ответ! У вас есть домашние животные?Да/Нет"))
        {
			//Животные есть, спрашиваем про их количество
			Console.WriteLine("Сколько у Вас животных?");
			CheckValueInt(Console.ReadLine(), out int countPets, "Не удалось определить кол-во животных! Укажите кол-во животных еще раз!");
			infoUser.namesPets =  new string[countPets];
			for (int i = 0; i < countPets; i++)
            {
				//Заполняем имя животных
				Console.WriteLine("Скажите кличку " + Convert.ToString(i+1)  + " животного.");
				CheckValueString(Console.ReadLine(), out string namePet, "Не удалось определить кличку животного! Укажите ее еще раз!");
				infoUser.namesPets[i]= namePet;
			}
		}

		//Спрашиваем про кол-во любимых цветов
		Console.WriteLine("Сколько у Вас любимых цветов?");
		CheckValueInt(Console.ReadLine(), out int countFavorsColors, "Не удалось определить кол-во любимых цветов! Укажите кол-во любимых цветов еще раз!");
		infoUser.namesFavorsColors = new string[countFavorsColors];
		for (int i = 0; i < countFavorsColors; i++)
		{
			//Заполняем имя животных
			Console.WriteLine("Скажите любимый цвет " + Convert.ToString(i + 1) );
			CheckValueString(Console.ReadLine(), out string nameFavorColor, "Не удалось определить любимый цвет! Укажите его еще раз!");
			infoUser.namesFavorsColors[i] = nameFavorColor;
		}
		return infoUser;
	}
	public static void ShowInfoUser((string nameUser, string secondNameUser, int age,
			string[] namesPets, string[] namesFavorsColors
			) infoUser)
    {
		Console.BackgroundColor = ConsoleColor.Red;
		Console.WriteLine("\nСбор информации закончен!!!");
		Console.WriteLine("Ваше имя - " + infoUser.nameUser);
		Console.WriteLine("Ваша фамилия - " + infoUser.secondNameUser);
		Console.WriteLine("Ваш возраст - " + infoUser.age);
		if(infoUser.namesPets.Length>0)
        {
			int countAnumals = infoUser.namesPets.Length;
			Console.WriteLine("У вас есть " + Convert.ToString(countAnumals) +" животных! Их клички:");
			for (int i = 0; i < countAnumals; i++)
            {
				Console.WriteLine(infoUser.namesPets[i]);
			}				
		}
		else
        {
			Console.WriteLine("У вас нет животных!");
		}
		if (infoUser.namesFavorsColors.Length > 0)
		{
			int countFavorsColors = infoUser.namesFavorsColors.Length;
			Console.WriteLine("У вас есть " + Convert.ToString(countFavorsColors) + " любимых цветов! Их названия:");
			for (int i = 0; i < countFavorsColors; i++)
			{
				Console.WriteLine(infoUser.namesFavorsColors[i]);
			}
		}
		else
		{
			Console.WriteLine("У вас нет любимых цветов!");
		}

	}
	private static void CheckValueInt(string value, out int correctNumber, string textMessage)
    {
		correctNumber = 0;
		if(int.TryParse(value, out int result))
        {
			if (result>0)
            {
				correctNumber = result;
			}
			else
            {
				Console.WriteLine(textMessage);
				CheckValueInt(Console.ReadLine(), out correctNumber, textMessage);
			}
		}
		else
        {
			Console.WriteLine(textMessage);
			CheckValueInt(Console.ReadLine(), out correctNumber, textMessage);
		}
    }

	private static void CheckValueString(string value, out string correctString, string textMessage)
    {
		correctString = "";
		if (int.TryParse(value, out int result))
		{
			Console.WriteLine(textMessage);
			CheckValueString(Console.ReadLine(), out correctString, textMessage);
		}
		else
        {
			correctString = value;
		}
	}

	private static bool CheckValueBool(string value, out bool result, string textMessage)
    {
		result = false;
		if(value=="Да" || value=="Нет")
        {
			if(value == "Да")
            {
				result = true;
			}
			else
            {
				result = false;
			}
		}
		else
        {
			Console.WriteLine(textMessage);
			CheckValueBool(Console.ReadLine(), out result, textMessage);
		}
		return result;
    }
}
