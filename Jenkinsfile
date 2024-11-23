pipeline {
	agent any
	stages {
		stage('Checkout') {
			steps {
				checkout scm
			}
		}
		stage('Build') {
			steps {
				bat 'dotnet build'
			}
		}
		stage('Test') {
			steps {
				bat 'dotnet test'
			}
		}
		stage('Publish') {
			steps {
				bat 'dotnet publish -c Release -o ./publish'
			}
		}
	}

	post {
		success {
			echo 'Pipeline ejecutado exitosamente'
		}
		failure {
			echo 'Pipeline falló'
		}
	}
}