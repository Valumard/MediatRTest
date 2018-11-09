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
        stage('') {
          steps {
            sh 'ls'
          }
        }
      }
    }
  }
}