Task tracker is a very simple command line app (can be integrated into a UI) that allows you to 
add, update, delete tasks which are saved into a file "tasks.json", saved into the same directory 
the executable is located in. The app does not yet have too many error checking for things such as 
wrong value types being used.

This is my implementation of the project idea from : https://roadmap.sh/projects/task-tracker

Please feel free to contact me on any criticms and or bugs :)

Below you will find how to use the app:

// Add a task, choose your own id INTEGER and the STRING description of the task
// the status of the task is automatically set 'todo'
// the id must be unique (it does not yet exist in the persistent file 'tasks.json')
    task-tracker-cli add {id: integer} {description: string}
    example: task-tracker-cli 1 clean bedroom

// Update the description of the task that has the specified id
// the id must already exist befire deleting
    task-tracker-cli update-description {id: integer} {description: string}
    example: task-tracker-cli 1 vacuum bedroom

// Delete the task that has the specified id
// the id must already exist befire deleting
    task-tracker-cli delete {id: integer}
    example: task-tracker-cli delete 1

// Update the status of the task that has the specified id
// newly added tasks automatically have 'todo' status
// recommended status are 'todo', 'in-progress', 'done' or 'complete'
// but feel free to name it what you want
// the id must already exist befire deleting
    task-tracker-cli update-status {id: integer} {status: string}
    example: task-tracker-cli update-status 1 in-progress


// lists all tasks by using 'all' or list all tasks with a certain status
    task-tracker-cli list all | {status: string}
    example: task-tracker-cli list all
    example: task-tracker-cli list todo
    example: task-tracker-cli list in-progress

