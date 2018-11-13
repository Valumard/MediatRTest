pipeline {
  agent any
  stages {
    stage('Restore') {
      steps {
        sh 'dotnet restore'
      }
    }
    stage('Build') {
      steps {
        sh 'dotnet build'
      }
    }
    stage('ParallelTest') {
      parallel {
        stage('archive') {
          steps {
            archiveArtifacts(artifacts: 'MediatrTest/bin/**.*', caseSensitive: true, fingerprint: true)
          }
        }
        stage('dockerTest') {
          steps {
            sh 'docker'
          }
        }
      }
    }
  }
}
