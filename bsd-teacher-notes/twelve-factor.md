# Twelve Facor App

> Authority: https://12factor.net/

## 1. Codebase

> Each *App* is in it's own source control repository. **Not** different repos for different environments (deploys).

## 2. Dependencies

> Dependencies to other libraries etc. come from package manager (Nuget, NPM, etc.). **No Libs Folder**

## 3. Config 

> Configuration is part of the environment, not the application.

## 4. Backing Services

> Other services you communicate with are all the same ontologically speaking. They are **attached resources**.

## 5. Build / Release / Run

> Build is in CI/CD - Release is separate from that. The environments "Run", not build.

## 6. Processes

> *Stateless* services are what we are paid to build. Maintain no state. Using #4 - Backing Services for state.

## 7. Port Binding

> Your service/application should run completely on it's own. No dependencies that aren't shipped with the build of the application. This means no IIS. 

## 8. Concurrency

> We do *horizontal* scaling, not *vertical* ("Scale out via the process model")

## 9. Disposability

> Fast startup and Shutdown, **ephemeral** services.

## 10. Dev / Prod Parity

> Prioritize doing everything you can to make all environments match as closely as possible. Avoid the "runs on my machine" issue.

## 11. Logs

> Logs are collected an aggregated and provide observability. 

## 12. Admin Process

> You still need Sysadmins. Someone has to setup databases, etc. That doesn't go in our Codebase.
