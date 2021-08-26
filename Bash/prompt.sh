#!/bin/bash
MESSAGE="If an argument entered it will echo here🍹 => "

if [ "$1" != "sag" ]; then
    echo "We don't do that in here 🤚"
else
    echo $MESSAGE $1 $2
fi

while true; do
    read -p "Question?(y/n) " yn
    case $yn in
        [Yy]* ) break;;
        [Nn]* ) exit;;
        * ) echo "Please answer yes or no. ";;
    esac
done