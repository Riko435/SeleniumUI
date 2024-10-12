pipeline  {
  agent any

  stages {
    stage('CleanWorkspace') {
      steps {
        cleanWs()
      }
    }

  stages {
    stage('Checkout') {
      steps {
          git 'https://github.com/Riko435/SeleniumUI.git'
      }
    }

    stage('Nuget Restore') {
      steps {
        echo "Restore Nuget package"
        sh "dotnet restore TestProject1"
      }
    }

    stage('Build Tests') {
      steps {
          echo "Build solution"
        sh "dotnet build TestProject1"
      }
    }

     stage('Run Tests') {
      steps {
        echo "Run UI Tests"
        sh "dotnet test TestProject1"
      }
    }

    stage('Generate Report') {
      steps {
        allure includeProperties:
                   false,
                     jdk: '',
                     results: [[path: 'build/allure-results']]
      }
    }
  }
}
    
