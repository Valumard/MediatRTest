pipeline {
  agent any
  stages {
    stage('TestAusgabe') {
      parallel {
        stage('TestAusgabe') {
          steps {
            echo 'Starting Build'
          }
        }
        stage('error') {
          steps {
            sh 'ls'
          }
        }
      }
    }
    stage('Build') {
      steps {
        sh 'dotnet'
      }
    }
  }
}