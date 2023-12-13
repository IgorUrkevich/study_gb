function myFunction() {
    var operator = prompt("Введите знак арифметической операции (+, -, *, /):");
    var number1 = parseFloat(prompt("Введите первое число:"));
    var number2 = parseFloat(prompt("Введите второе число:"));
  
    function calculator(number1, number2, operator) {
      var result;
  
      switch (operator) {
        case "+":
          result = number1 + number2;
          break;
        case "-":
          result = number1 - number2;
          break;
        case "*":
          result = number1 * number2;
          break;
        case "/":
          result = number1 / number2;
          break;
        default:
          result = "Недопустимая операция";
      }
  
      return result;
    }
  
    var calculationResult = calculator(number1, number2, operator);
    alert("Результат: " + calculationResult);
  }