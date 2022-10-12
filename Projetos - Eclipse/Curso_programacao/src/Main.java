import java.util.Locale;

public class Main {

	public static void main(String[] args) {
		
		
		int idade;
		double salario; 
		String nome; 
		char sexo; 
		
		idade = 32; 
		salario = 4560.9; 
		nome = "Maria Silva"; 
		sexo = 'F';
		
		System.out.println("A Funcionaria " + nome + ", sexo " + sexo + ", ganha " + String.format("%.2f", salario) + " e tem " + idade + " anos");

	}

}
