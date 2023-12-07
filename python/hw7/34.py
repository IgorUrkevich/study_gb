def check_rhythm(poem):
    lines = poem.split(" ")
    syllables = []
    
    for line in lines:
        words = line.split("-")
        syllable_count = 0
        
        for word in words:
            vowel_count = sum(1 for char in word if char.lower() in "aeoаеёиоуыэюя")
            syllable_count += vowel_count
        
        syllables.append(syllable_count)
    
    if len(set(syllables)) == 1:
        return "Парам пам-пам"
    else:
        return "Пам парам"

poem = input("Введите стихотворение Винни-Пуха: ")

result = check_rhythm(poem)
print(result)